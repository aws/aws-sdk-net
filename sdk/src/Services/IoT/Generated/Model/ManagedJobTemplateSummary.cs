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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// An object that contains information about the managed template.
    /// </summary>
    public partial class ManagedJobTemplateSummary
    {
        private string _description;
        private List<string> _environments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _templateArn;
        private string _templateName;
        private string _templateVersion;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for a managed template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        /// A list of environments that are supported with the managed job template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Environments
        {
            get { return this._environments; }
            set { this._environments = value; }
        }

        // Check to see if Environments property is set
        internal bool IsSetEnvironments()
        {
            return this._environments != null && (this._environments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for a managed template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The unique Name for a managed template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVersion. 
        /// <para>
        /// The version for a managed template.
        /// </para>
        /// </summary>
        public string TemplateVersion
        {
            get { return this._templateVersion; }
            set { this._templateVersion = value; }
        }

        // Check to see if TemplateVersion property is set
        internal bool IsSetTemplateVersion()
        {
            return this._templateVersion != null;
        }

    }
}