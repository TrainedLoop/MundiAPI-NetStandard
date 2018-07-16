/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.NetStandard;
using MundiAPI.NetStandard.Utilities;


namespace MundiAPI.NetStandard.Models
{
    public class ListSellerResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.GetSellerResponse> data;
        private Models.PagingResponse paging;

        /// <summary>
        /// The order object
        /// </summary>
        [JsonProperty("data")]
        public List<Models.GetSellerResponse> Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Paging object
        /// </summary>
        [JsonProperty("paging")]
        public Models.PagingResponse Paging 
        { 
            get 
            {
                return this.paging; 
            } 
            set 
            {
                this.paging = value;
                onPropertyChanged("Paging");
            }
        }
    }
} 