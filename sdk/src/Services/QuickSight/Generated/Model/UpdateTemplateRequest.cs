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
    /// Container for the parameters to the UpdateTemplate operation.
    /// Updates a template from an existing Amazon QuickSight analysis or another template.
    /// </summary>
    public partial class UpdateTemplateRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private TemplateVersionDefinition _definition;
        private string _name;
        private TemplateSourceEntity _sourceEntity;
        private string _templateId;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the template that you're updating.
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
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of a template.
        /// </para>
        ///  
        /// <para>
        /// A definition is the data model of all features in a Dashboard, Template, or Analysis.
        /// </para>
        /// </summary>
        public TemplateVersionDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// The entity that you are using as a source when you update the template. In <code>SourceEntity</code>,
        /// you specify the type of object you're using as source: <code>SourceTemplate</code>
        /// for a template or <code>SourceAnalysis</code> for an analysis. Both of these require
        /// an Amazon Resource Name (ARN). For <code>SourceTemplate</code>, specify the ARN of
        /// the source template. For <code>SourceAnalysis</code>, specify the ARN of the source
        /// analysis. The <code>SourceTemplate</code> ARN can contain any Amazon Web Services
        /// account and any Amazon QuickSight-supported Amazon Web Services Region;. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>DataSetReferences</code> entity within <code>SourceTemplate</code> or
        /// <code>SourceAnalysis</code> to list the replacement datasets for the placeholders
        /// listed in the original. The schema in each dataset must match its placeholder. 
        /// </para>
        /// </summary>
        public TemplateSourceEntity SourceEntity
        {
            get { return this._sourceEntity; }
            set { this._sourceEntity = value; }
        }

        // Check to see if SourceEntity property is set
        internal bool IsSetSourceEntity()
        {
            return this._sourceEntity != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID for the template.
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
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description of the current template version that is being updated. Every time you
        /// call <code>UpdateTemplate</code>, you create a new version of the template. Each version
        /// of the template maintains a description of the version in the <code>VersionDescription</code>
        /// field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}