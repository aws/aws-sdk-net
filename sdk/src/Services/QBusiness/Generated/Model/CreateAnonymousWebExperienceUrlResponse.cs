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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the CreateAnonymousWebExperienceUrl operation.
    /// </summary>
    public partial class CreateAnonymousWebExperienceUrlResponse : AmazonWebServiceResponse
    {
        private string _anonymousUrl;

        /// <summary>
        /// Gets and sets the property AnonymousUrl. 
        /// <para>
        /// The unique URL for accessing the web experience.
        /// </para>
        ///  <important> 
        /// <para>
        /// This URL can only be used once and must be used within 5 minutes after it's generated.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AnonymousUrl
        {
            get { return this._anonymousUrl; }
            set { this._anonymousUrl = value; }
        }

        // Check to see if AnonymousUrl property is set
        internal bool IsSetAnonymousUrl()
        {
            return this._anonymousUrl != null;
        }

    }
}