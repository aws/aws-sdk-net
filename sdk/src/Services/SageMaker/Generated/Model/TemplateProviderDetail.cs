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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details about a template provider configuration and associated provisioning information.
    /// </summary>
    public partial class TemplateProviderDetail
    {
        private CfnTemplateProviderDetail _cfnTemplateProviderDetail;

        /// <summary>
        /// Gets and sets the property CfnTemplateProviderDetail. 
        /// <para>
        ///  Details about a CloudFormation template provider configuration and associated provisioning
        /// information. 
        /// </para>
        /// </summary>
        public CfnTemplateProviderDetail CfnTemplateProviderDetail
        {
            get { return this._cfnTemplateProviderDetail; }
            set { this._cfnTemplateProviderDetail = value; }
        }

        // Check to see if CfnTemplateProviderDetail property is set
        internal bool IsSetCfnTemplateProviderDetail()
        {
            return this._cfnTemplateProviderDetail != null;
        }

    }
}