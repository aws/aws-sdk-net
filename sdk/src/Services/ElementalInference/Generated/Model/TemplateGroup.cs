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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// A named set of graphics-compositing templates used by the crop feature, specified
    /// in the templateGroups array of a CroppingConfig.
    /// </summary>
    public partial class TemplateGroup
    {
        private string _name;
        private List<string> _templateUris = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the template group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TemplateUris. 
        /// <para>
        /// An array of Amazon S3 URIs that point to the graphics-compositing templates for this
        /// group. You can specify 1 or 2 URIs. Each URI must be in the form <c>s3://bucket-name/key</c>.
        /// Elemental Inference reads these templates using the IAM role that you specify in accessRoleArn.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> TemplateUris
        {
            get { return this._templateUris; }
            set { this._templateUris = value; }
        }

        // Check to see if TemplateUris property is set
        internal bool IsSetTemplateUris()
        {
            return this._templateUris != null && (this._templateUris.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}