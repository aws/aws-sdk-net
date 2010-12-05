using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract class for Response objects, contains only metadata, 
    /// and no result information.
    /// </summary>
    public class AmazonWebServiceResponse
    {
        private ResponseMetadata responseMetaDataField;

        /// <summary>
        /// Contains additional information about the request, such as the 
        /// Request Id.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return  responseMetaDataField; }
            set { responseMetaDataField = value; }
        }
    }
}
