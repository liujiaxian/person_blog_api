using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;

namespace MvcApi.Controllers
{
    public class ValuesController : ApiController
    {
        bds252114683_dbEntities db = new bds252114683_dbEntities();

        int count = 0;
        int pageSize = 5;

        #region 博客接口
        #region 首页博客信息
        public object GetBlog()
        {
            var list = db.person_vyw_blog_type.Where(c => true).OrderByDescending(c => c.blogID).Take(5).ToList();

            var newlist = from d in list
                          select new
                          {
                              userPictureUrl = d.userPictureUrl,
                              blogID = d.blogID,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              title = d.title,
                              typeID = d.typeID,
                              typeName = d.typeName,
                              userID = d.userID,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss"),
                          };

            return newlist;
        }
        #endregion

        #region 博客列表
        [HttpPost]
        public object PostBlogList(int? page, int? typeid)
        {
            if (string.IsNullOrEmpty(page.ToString()))
            {
                return null;
            }
            IQueryable<person_vyw_blog_type> result = db.person_vyw_blog_type.Where(c => true);
            List<person_vyw_blog_type> list = null;
            object newlist = null;

            if (string.IsNullOrEmpty(typeid.ToString()))
            {
                typeid = 0;
            }


            if (typeid > 0)
            {
                result = result.Where(c => c.typeID == typeid);
            }


            count = result.Count();

            int pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);

            if (page < 1)
            {
                return null;
            }

            if (page > pageCount)
            {
                return null;
            }

            if (count > 0)
            {
                list = result.OrderByDescending(c => c.blogID).Skip((Convert.ToInt32(page) - 1) * pageSize).Take(pageSize).ToList();

                newlist = from d in list
                          select new
                          {
                              blogID = d.blogID,
                              content = d.content,
                              describe = d.describe,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              hot = d.hot,
                              tags = d.tags,
                              title = d.title,
                              typeName = d.typeName,
                              typeID = d.typeID,
                              userID = d.userID,
                              userPictureUrl = d.userPictureUrl,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss")
                          };
            }

            return newlist;
        }
        #endregion

        #region 博客详细
        public object GetBlogDetail(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var model = db.person_vyw_blog_type.Where(c => c.blogID == id).FirstOrDefault();
            if (model == null)
            {
                return null;
            }

            var newmodel = new
            {
                blogID = model.blogID,
                content = model.content,
                describe = model.describe,
                hot = model.hot,
                userPictureUrl = model.userPictureUrl,
                url = model.url,
                typeName = model.typeName,
                typeID = model.typeID,
                userID = model.userID,
                title = model.title,
                tags = model.tags,
                nickName = string.IsNullOrEmpty(model.nickName) ? model.username : model.nickName,
                addTime = Convert.ToDateTime(model.addTime).ToString("yyyy-MM-dd HH:mm:ss")
            };

            return newmodel;
        }
        #endregion
        #endregion

        #region 轮播接口
        #region 首页轮播信息
        public object GetBanner()
        {
            var list = db.person_vyw_banner_user.Where(c => c.isDelete == false && c.isRecommend == true).OrderByDescending(c => c.bannerID).ToList();

            var newlist = from d in list
                          select new
                          {
                              url = d.url,
                              bannerID = d.bannerID,
                              title = d.title,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss")
                          };

            return newlist;
        }
        #endregion

        #region 轮播详细
        public object GetBannerDetail(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var model = db.person_vyw_banner_user.Where(c => c.isDelete == false && c.bannerID == id).FirstOrDefault();
            if (model == null)
            {
                return null;
            }

            var newmodel = new
            {
                content = model.content,
                describe = model.describe,
                tags = model.tags,
                title = model.title,
                url = model.url,
                userPictureUrl = model.userPictureUrl,
                nickName = string.IsNullOrEmpty(model.nickName) ? model.username : model.nickName,
                addTime = Convert.ToDateTime(model.addTime).ToString("yyyy-MM-dd HH:mm:ss"),
                hot = model.hot,
                userID = model.userID
            };

            return newmodel;
        }
        #endregion

        #region 轮播列表
        [HttpPost]
        public object PostBannerList(int? page)
        {
            if (string.IsNullOrEmpty(page.ToString()))
            {
                return null;
            }
            IQueryable<person_vyw_banner_user> result = db.person_vyw_banner_user.Where(c => c.isDelete == false && c.isRecommend == false);
            List<person_vyw_banner_user> list = null;
            object newlist = null;

            //switch (orderbyid)
            //{
            //    case -1://推荐
            //        result = result.Where(c => c.isRecommend == true).OrderByDescending(c => c.bannerID);
            //        break;
            //    case -2://热门
            //        result = result.OrderByDescending(c => c.hot);
            //        break;
            //    default:
            //        result = result.OrderByDescending(c => c.bannerID);
            //        break;
            //}

            count = result.Count();

            int pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);

            if (page < 1)
            {
                return null;
            }

            if (page > pageCount)
            {
                return null;
            }

            if (count > 0)
            {
                list = result.OrderByDescending(c => c.hot).Skip((Convert.ToInt32(page) - 1) * pageSize).Take(pageSize).ToList();

                newlist = from d in list
                          select new
                          {
                              bannerID = d.bannerID,
                              content = d.content,
                              describe = d.describe,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              hot = d.hot,
                              tags = d.tags,
                              title = d.title,
                              url = d.url,
                              userID = d.userID,
                              userPictureUrl = d.userPictureUrl,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss")
                          };
            }

            return newlist;
        }
        #endregion

        #endregion

        #region 获取会员信息
        public object GetMemberInfo(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var model = db.person_vyw_user_picture.Where(c => c.status == (int)MvcApi.Models.Enum_Member_Status.正常 && c.userID == id).FirstOrDefault();
            if (model == null)
            {
                return null;
            }

            var newmodel = new
            {
                nickName = string.IsNullOrEmpty(model.nickName) ? model.username : model.nickName,
                sex = Enum.GetName(typeof(MvcApi.Models.Enum_Sex), model.sex),
                email = model.email,
                addTime = Convert.ToDateTime(model.signTime).ToString("yyyy-MM-dd HH:mm:ss"),
                score = model.score,
                motto = model.motto,
                signature = model.signature,
                url = model.url
            };

            return newmodel;
        }
        #endregion

        #region 计划接口
        #region 首页计划信息
        public object GetPlan()
        {
            var list = db.person_vyw_plan_user.Where(c => true).OrderByDescending(c => c.planID).Take(5).ToList();

            var newlist = from d in list
                          select new
                          {
                              url = d.url,
                              planID = d.planID,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              title = d.title,
                              isRecommend = Convert.ToBoolean(d.isRecommend) ? "推荐" : "未推荐",
                              userID = d.userID,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss"),
                          };

            return newlist;
        }
        #endregion

        #region 计划列表
        [HttpPost]
        public object PostPlanList(int? page)
        {
            if (string.IsNullOrEmpty(page.ToString()))
            {
                return null;
            }

            IQueryable<person_vyw_plan_user> result = db.person_vyw_plan_user.Where(c => true);
            List<person_vyw_plan_user> list = null;
            object newlist = null;

            count = result.Count();

            int pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);

            if (page < 1)
            {
                return null;
            }

            if (page > pageCount)
            {
                return null;
            }

            if (count > 0)
            {
                list = result.OrderByDescending(c => c.planID).Skip((Convert.ToInt32(page) - 1) * pageSize).Take(pageSize).ToList();

                newlist = from d in list
                          select new
                          {
                              url = d.url,
                              planID = d.planID,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              title = d.title,
                              isRecommend = Convert.ToBoolean(d.isRecommend) ? "推荐" : "未推荐",
                              userID = d.userID,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss"),
                          };
            }

            return newlist;
        }
        #endregion

        #region 计划详细
        public object GetPlanDetail(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var model = db.person_vyw_plan_user.Where(c => c.planID == id).FirstOrDefault();
            if (model == null)
            {
                return null;
            }

            var newmodel = new
            {
                hot = model.hot,
                describe = model.describe,
                nickName = string.IsNullOrEmpty(model.nickName) ? model.username : model.nickName,
                userID = model.userID,
                title = model.title,
                tags = model.tags,
                isRecommend = Convert.ToBoolean(model.isRecommend) ? "推荐" : "未推荐",
                url = model.url,
                addTime = Convert.ToDateTime(model.addTime).ToString("yyyy-MM-dd HH:mm:ss")
            };

            return newmodel;
        }
        #endregion

        #region 计划详细
        public object GetPlanContentList(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var list = db.person_vyw_plan_content.Where(c => c.planID == id).OrderBy(c=>c.weight).ToList();
            if (list.Count<=0)
            {
                return null;
            }

            var newlist = from d in list
                      select new
                      {
                          title = d.title,
                          weight = d.weight,
                          content=  d.content,
                          status = Enum.GetName(typeof(MvcApi.Models.Enum_PlanStatus),d.status),
                          startTime = Convert.ToDateTime(d.startTime).ToString("yyyy-MM-dd HH:mm:ss"),
                          endTime = Convert.ToDateTime(d.endTime).ToString("yyyy-MM-dd HH:mm:ss"),
                      };

            return newlist;
        }
        #endregion
        #endregion

        #region 图书接口
        #region 首页图书信息
        public object GetBook()
        {
            var list = db.person_vyw_reader_user.Where(c => true).OrderByDescending(c => c.readerID).Take(5).ToList();

            var newlist = from d in list
                          select new
                          {
                              url = d.url,
                              bookID = d.readerID,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              title = d.readerTitle,
                              typeID = d.typeID,
                              typeName = d.typeName,
                              userID = d.userID,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss"),
                          };

            return newlist;
        }
        #endregion

        #region 图书列表
        [HttpPost]
        public object PostBookList(int? page, int? typeid)
        {
            if (string.IsNullOrEmpty(page.ToString()))
            {
                return null;
            }
            IQueryable<person_vyw_reader_user> result = db.person_vyw_reader_user.Where(c => true);
            List<person_vyw_reader_user> list = null;
            object newlist = null;

            if (typeid > 0)
            {
                result = result.Where(c => c.typeID == typeid);
            }


            count = result.Count();

            int pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);

            if (page < 1)
            {
                return null;
            }

            if (page > pageCount)
            {
                return null;
            }

            if (count > 0)
            {
                list = result.OrderByDescending(c => c.readerID).Skip((Convert.ToInt32(page) - 1) * pageSize).Take(pageSize).ToList();

                newlist = from d in list
                          select new
                          {
                              url = d.url,
                              bookID = d.readerID,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              title = d.readerTitle,
                              typeID = d.typeID,
                              typeName = d.typeName,
                              userID = d.userID,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss"),
                          };
            }

            return newlist;
        }
        #endregion

        #region 图书详细
        public object GetBookDetail(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var model = db.person_vyw_reader_user.Where(c => c.readerID == id).FirstOrDefault();
            if (model == null)
            {
                return null;
            }

            var newmodel = new
            {
                title = model.readerTitle,
                tags = model.tags,
                typeID = model.typeID,
                typeName = model.typeName,
                url = model.url,
                userID = model.userID,
                hot = model.hot,
                readerDescribe = model.readerDescribe,
                nickName = string.IsNullOrEmpty(model.nickName) ? model.username : model.nickName
            };

            return newmodel;
        }
        #endregion
        #endregion

        #region 项目接口
        #region 首页项目信息
        public object GetCase()
        {
            var list = db.person_vyw_case_type_user_picture.Where(c => c.isDelete == false).OrderByDescending(c => c.caseID).Take(5).ToList();

            var newlist = from d in list
                          select new
                          {
                              url = d.url,
                              userID = d.userID,
                              userPictureUrl = d.userPictureUrl,
                              caseID = d.caseID,
                              typeName = d.name,
                              typeID = d.typeID,
                              title = d.title,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss")
                          };

            return newlist;
        }
        #endregion

        #region 项目详细
        public object GetCaseDetail(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return null;
            }

            var model = db.person_vyw_case_type_user_picture.Where(c => c.isDelete == false && c.caseID == id).FirstOrDefault();
            if (model == null)
            {
                return null;
            }

            var newmodel = new
            {
                title = model.title,
                describe = model.describe,
                content = model.content,
                hot = model.hot,
                name = model.name,
                typeID = model.typeID,
                userID = model.userID,
                nickName = string.IsNullOrEmpty(model.nickName) ? model.username : model.nickName,
                addTime = Convert.ToDateTime(model.addTime).ToString("yyyy-MM-dd HH:mm:ss")
            };

            return model;
        }
        #endregion

        #region 项目列表
        [HttpPost]
        public object PostCaseList(int? page, int? typeid)
        {
            if (string.IsNullOrEmpty(page.ToString()))
            {
                return null;
            }
            IQueryable<person_vyw_case_type_user_picture> result = db.person_vyw_case_type_user_picture.Where(c => c.isDelete == false);
            List<person_vyw_case_type_user_picture> list = null;
            object newlist = null;

            //switch (orderbyid)
            //{
            //    case -1://推荐
            //        result = result.Where(c => c.isRecommend == true).OrderByDescending(c => c.bannerID);
            //        break;
            //    case -2://热门
            //        result = result.OrderByDescending(c => c.hot);
            //        break;
            //    default:
            //        result = result.OrderByDescending(c => c.bannerID);
            //        break;
            //}

            if (string.IsNullOrEmpty(typeid.ToString()))
            {
                typeid = 0;
            }

            if (typeid > 0)
            {
                result = result.Where(c => c.typeID == typeid);
            }

            count = result.Count();

            int pageCount = (int)Math.Ceiling(count * 1.0 / pageSize);

            if (page < 1)
            {
                return null;
            }

            if (page > pageCount)
            {
                return null;
            }

            if (count > 0)
            {
                list = result.OrderByDescending(c => c.caseID).Skip((Convert.ToInt32(page) - 1) * pageSize).Take(pageSize).ToList();

                newlist = from d in list
                          select new
                          {
                              url = d.url,
                              userID = d.userID,
                              userPictureUrl = d.userPictureUrl,
                              caseID = d.caseID,
                              typeName = d.name,
                              typeID = d.typeID,
                              title = d.title,
                              nickName = string.IsNullOrEmpty(d.nickName) ? d.username : d.nickName,
                              hot = d.hot,
                              addTime = Convert.ToDateTime(d.addTime).ToString("yyyy-MM-dd HH:mm:ss")
                          };
            }

            return newlist;
        }
        #endregion

        #endregion
    }
}

