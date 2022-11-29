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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTemplateDefinition operation.
    /// Provides a detailed description of the definition of a template.
    /// 
    ///  <note> 
    /// <para>
    /// If you do not need to know details about the content of a template, for instance if
    /// you are trying to check the status of a recently created or updated template, use
    /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeTemplate.html">
    /// <code>DescribeTemplate</code> </a> instead. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeTemplateDefinitionRequest : AmazonQuickSightRequest
    {
        private string _aliasName;
        private string _awsAccountId;
        private string _templateId;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias of the template that you want to describe. If you name a specific alias,
        /// you describe the version that the alias points to. You can specify the latest version
        /// of the template by providing the keyword <code>$LATEST</code> in the <code>AliasName</code>
        /// parameter. The keyword <code>$PUBLISHED</code> doesn't apply to templates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the template. You must be
        /// using the Amazon Web Services account that the template is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template that you're describing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}