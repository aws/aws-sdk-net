/* 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for AnalyticsExportDestination
    /// </summary>
    public class AnalyticsExportDestination
    {
        private AnalyticsS3BucketDestination analyticsS3BucketDestination;

        /// <summary>
        /// A destination signifying output to an S3 bucket.
        /// </summary>
        public AnalyticsS3BucketDestination S3BucketDestination
        {
            get { return this.analyticsS3BucketDestination; }
            set { this.analyticsS3BucketDestination = value; }
        }

        // Check to see if S3BucketDestination property is set
        internal bool IsSetS3BucketDestination()
        {
            return this.analyticsS3BucketDestination != null;
        }
    }
}
