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
    /// This is the response object from the CreateWebExperience operation.
    /// </summary>
    public partial class CreateWebExperienceResponse : AmazonWebServiceResponse
    {
        private string _webExperienceArn;
        private string _webExperienceId;

        /// <summary>
        /// Gets and sets the property WebExperienceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of an Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string WebExperienceArn
        {
            get { return this._webExperienceArn; }
            set { this._webExperienceArn = value; }
        }

        // Check to see if WebExperienceArn property is set
        internal bool IsSetWebExperienceArn()
        {
            return this._webExperienceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of the Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string WebExperienceId
        {
            get { return this._webExperienceId; }
            set { this._webExperienceId = value; }
        }

        // Check to see if WebExperienceId property is set
        internal bool IsSetWebExperienceId()
        {
            return this._webExperienceId != null;
        }

    }
}