using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Response from creating a presigned POST request for S3.
    /// Contains the URL and form fields needed for a browser-based file upload directly to S3.
    /// </summary>
    public class CreatePresignedPostResponse
    {
        /// <summary>
        /// Gets the URL where the POST request should be submitted.
        /// </summary>
        public string Url { get; set; }
        
        /// <summary>
        /// Gets the form fields that must be included in the POST request.
        /// These fields contain the policy, signature, and other AWS-required parameters.
        /// </summary>
        public Dictionary<string, string> Fields { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the CreatePresignedPostResponse class.
        /// </summary>
        public CreatePresignedPostResponse()
        {
            Fields = new Dictionary<string, string>();
        }
    }

}
