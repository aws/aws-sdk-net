/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
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

/*
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// This is the response object from the DisassociateS3Resources operation.
    /// </summary>
    public partial class DisassociateS3ResourcesResponse : AmazonWebServiceResponse
    {
        private List<FailedS3Resource> _faileds3Resources = new List<FailedS3Resource>();

        /// <summary>
        /// Gets and sets the property FailedS3Resources. 
        /// <para>
        /// S3 resources that couldn't be removed from being monitored and classified by Amazon
        /// Macie. An error code and an error message are provided for each failed item. 
        /// </para>
        /// </summary>
        public List<FailedS3Resource> FailedS3Resources
        {
            get { return this._faileds3Resources; }
            set { this._faileds3Resources = value; }
        }

        // Check to see if FailedS3Resources property is set
        internal bool IsSetFailedS3Resources()
        {
            return this._faileds3Resources != null && this._faileds3Resources.Count > 0; 
        }

    }
}