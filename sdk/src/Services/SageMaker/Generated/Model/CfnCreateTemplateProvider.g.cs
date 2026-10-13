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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The CloudFormation template provider configuration for creating infrastructure resources.
    /// </summary>
    public partial class CfnCreateTemplateProvider
    {
        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  An array of CloudFormation stack parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 180)]
        public List<CfnStackCreateParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<CfnStackCreateParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        ///  The IAM role that CloudFormation assumes when creating the stack. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///  A unique identifier for the template within the project. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateURL. 
        /// <para>
        ///  The Amazon S3 URL of the CloudFormation template. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// Checks to see if the TemplateURL property is set.
        /// </summary>
        internal bool IsSetTemplateURL() => this.TemplateURL != null;
    }
}
