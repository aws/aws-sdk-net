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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// This is the response object from the DeletePlatformVersion operation.
    /// </summary>
    public partial class DeletePlatformVersionResponse : AmazonWebServiceResponse
    {
        private PlatformSummary _platformSummary;

        /// <summary>
        /// Gets and sets the property PlatformSummary. 
        /// <para>
        /// Detailed information about the version of the custom platform.
        /// </para>
        /// </summary>
        public PlatformSummary PlatformSummary
        {
            get { return this._platformSummary; }
            set { this._platformSummary = value; }
        }

        // Check to see if PlatformSummary property is set
        internal bool IsSetPlatformSummary()
        {
            return this._platformSummary != null;
        }

    }
}