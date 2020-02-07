﻿using Common.Common;
using DocumentManagement.Common;
using DocumentManagement.Model;
using DocumentManagement.Model.Entity.TableOfContens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.DAL
{
    public class TableOfContentsDAL
    {
        private TableOfContentsDAL() { }

        private static volatile TableOfContentsDAL _instance;

        static object key = new object();

        public static TableOfContentsDAL GetTableOfContentsDALInstance
        {
            get
            {
                lock (key)
                {
                    if (_instance == null)
                    {
                        _instance = new TableOfContentsDAL();
                    }
                }

                return _instance;
            }

            private set
            {
                _instance = value;
            }
        }
        public ReturnResult<TableOfContents> GetPagingWithSearchResults(BaseCondition<TableOfContents> condition)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            dbProvider.SetQuery("TableOfContents_GET_PAGING", CommandType.StoredProcedure)
                .SetParameter("FromRecord", SqlDbType.NVarChar, condition.FromRecord, ParameterDirection.Input)
                .SetParameter("PageSize", SqlDbType.NVarChar, condition.PageSize, ParameterDirection.Input)
                .SetParameter("InWhere", SqlDbType.NVarChar, condition.IN_WHERE, ParameterDirection.Input)
                .SetParameter("InSort", SqlDbType.NVarChar, condition.IN_SORT, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
        public ReturnResult<TableOfContents> GetAllTableOfContents()
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_GET_ALL", CommandType.StoredProcedure)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> TableOfContentsSearch(string searchStr)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_SEARCH", CommandType.StoredProcedure)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> GetTableOfContentsByID(int tablleOfContentsID)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_GET_BY_ID", CommandType.StoredProcedure)
                .SetParameter("MucLucHoSoID", SqlDbType.Int, tablleOfContentsID, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> GetTableOfContentsByFontID(int fontID)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_GET_BY_FONTID", CommandType.StoredProcedure)
                .SetParameter("PhongID", SqlDbType.Int, fontID, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> GetTableOfContentsByRepositoryID(int repositoryID)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_GET_BY_REPOSITORYID", CommandType.StoredProcedure)
                .SetParameter("KhoID", SqlDbType.Int, repositoryID, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> GetTableOfContentsByStorageID(int storageID)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_GET_BY_STORAGEID", CommandType.StoredProcedure)
                .SetParameter("PhongID", SqlDbType.Int, storageID, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> DeleteTableOfContents(int tableOfContentsID) {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_DELETE", CommandType.StoredProcedure)
                .SetParameter("MucLucHoSoID", SqlDbType.Int, tableOfContentsID, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> UpdateTableOfContents(TableOfContents TableOfContents)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_EDIT", CommandType.StoredProcedure)
                .SetParameter("MucLucHoSoID", SqlDbType.Int, TableOfContents.TabOfContID, ParameterDirection.Input)
                .SetParameter("TenMucLucHoSo", SqlDbType.NVarChar, TableOfContents.TabOfContName ,50, ParameterDirection.Input)
                .SetParameter("LuuTruID", SqlDbType.Int, TableOfContents.StorageID, ParameterDirection.Input)
                .SetParameter("PhongID", SqlDbType.Int, TableOfContents.FontID, ParameterDirection.Input)
                .SetParameter("KhoID", SqlDbType.Int, TableOfContents.RepositoryID, ParameterDirection.Input)
                .SetParameter("MucLucSo", SqlDbType.Int, TableOfContents.TabOfContNumber, ParameterDirection.Input)
                .SetParameter("MaDanhMuc", SqlDbType.NVarChar, TableOfContents.CategoryCode, 50, ParameterDirection.Input)
                .SetParameter("GhiChu", SqlDbType.NVarChar, TableOfContents.Note, 50, ParameterDirection.Input)
                .SetParameter("NgayCapNhat", SqlDbType.DateTime, TableOfContents.UpdateTime, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
        public ReturnResult<TableOfContents> InsertTableOfContents(TableOfContents TableOfContents)
        {
            List<TableOfContents> TableOfContentsList = new List<TableOfContents>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("TableOfContents_INSERT", CommandType.StoredProcedure)
                .SetParameter("TenMucLucHoSo", SqlDbType.NVarChar, TableOfContents.TabOfContName, 50, ParameterDirection.Input)
                .SetParameter("LuuTruID", SqlDbType.Int, TableOfContents.StorageID, ParameterDirection.Input)
                .SetParameter("PhongID", SqlDbType.Int, TableOfContents.FontID, ParameterDirection.Input)
                .SetParameter("KhoID", SqlDbType.Int, TableOfContents.RepositoryID, ParameterDirection.Input)
                .SetParameter("MucLucSo", SqlDbType.Int, TableOfContents.TabOfContNumber, ParameterDirection.Input)
                .SetParameter("NgayTao", SqlDbType.DateTime, TableOfContents.CreatTime, ParameterDirection.Input)
                .SetParameter("MaDanhMuc", SqlDbType.NVarChar, TableOfContents.CategoryCode, 50, ParameterDirection.Input)
                .SetParameter("GhiChu", SqlDbType.NVarChar, TableOfContents.Note, 50, ParameterDirection.Input)
                .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .GetList<TableOfContents>(out TableOfContentsList)
                .Complete();
            dbProvider.GetOutValue("ErrorCode", out outCode)
                       .GetOutValue("ErrorMessage", out outMessage);

            return new ReturnResult<TableOfContents>()
            {
                ItemList = TableOfContentsList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
    }
}
