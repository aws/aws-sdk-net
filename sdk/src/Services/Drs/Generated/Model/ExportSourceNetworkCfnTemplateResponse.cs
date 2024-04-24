/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Drs.Model
{
    /// <summary>
    /// This is the response object from the ExportSourceNetworkCfnTemplate operation.
    /// </summary>
    public partial class ExportSourceNetworkCfnTemplateResponse : AmazonWebServiceResponse
    {
        private string _s3DestinationUrl;

        /// <summary>
        /// Gets and sets the property S3DestinationUrl. 
        /// <para>
        /// S3 bucket URL where the Source Network CloudFormation template was exported to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string S3DestinationUrl
        {
            get { return this._s3DestinationUrl; }
            set { this._s3DestinationUrl = value; }
        }

        // Check to see if S3DestinationUrl property is set
        internal bool IsSetS3DestinationUrl()
        {
            return this._s3DestinationUrl != null;
        }

    }
}