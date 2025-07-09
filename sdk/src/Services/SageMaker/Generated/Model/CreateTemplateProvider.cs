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
    /// Contains configuration details for a template provider. Only one type of template
    /// provider can be specified.
    /// </summary>
    public partial class CreateTemplateProvider
    {
        private CfnCreateTemplateProvider _cfnTemplateProvider;

        /// <summary>
        /// Gets and sets the property CfnTemplateProvider. 
        /// <para>
        ///  The CloudFormation template provider configuration for creating infrastructure resources.
        /// 
        /// </para>
        /// </summary>
        public CfnCreateTemplateProvider CfnTemplateProvider
        {
            get { return this._cfnTemplateProvider; }
            set { this._cfnTemplateProvider = value; }
        }

        // Check to see if CfnTemplateProvider property is set
        internal bool IsSetCfnTemplateProvider()
        {
            return this._cfnTemplateProvider != null;
        }

    }
}