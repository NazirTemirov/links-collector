﻿using System;

namespace LinksCollector.DataAccessLayer.DataModels
{
    public class RequestDataModel: IBaseDataModel
    {
        public Int64 Id { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The request url
        /// </summary>
        public String Url { get; set; }

        /// <summary>
        /// Count of hyperlinks on the requested page
        /// </summary>
        public Int32 HyperlinksCount { get; set; }
    }
}
