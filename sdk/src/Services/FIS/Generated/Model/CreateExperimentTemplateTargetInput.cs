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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FIS.Model
{
    /// <summary>
    /// Specifies a target for an experiment. You must specify at least one Amazon Resource
    /// Name (ARN) or at least one resource tag. You cannot specify both ARNs and tags.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/targets.html">Targets</a>
    /// in the <i>Fault Injection Simulator User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateExperimentTemplateTargetInput
    {
        private List<ExperimentTemplateTargetInputFilter> _filters = new List<ExperimentTemplateTargetInputFilter>();
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<string> _resourceArns = new List<string>();
        private Dictionary<string, string> _resourceTags = new Dictionary<string, string>();
        private string _resourceType;
        private string _selectionMode;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to identify target resources using specific attributes.
        /// </para>
        /// </summary>
        public List<ExperimentTemplateTargetInputFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The resource type parameters.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the resources.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags for the target resources.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public Dictionary<string, string> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. The resource type must be supported for the specified action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionMode. 
        /// <para>
        /// Scopes the identified resources to a specific count of the resources at random, or
        /// a percentage of the resources. All identified resources are included in the target.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ALL - Run the action on all identified targets. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COUNT(n) - Run the action on the specified number of targets, chosen from the identified
        /// targets at random. For example, COUNT(1) selects one of the targets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PERCENT(n) - Run the action on the specified percentage of targets, chosen from the
        /// identified targets at random. For example, PERCENT(25) selects 25% of the targets.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string SelectionMode
        {
            get { return this._selectionMode; }
            set { this._selectionMode = value; }
        }

        // Check to see if SelectionMode property is set
        internal bool IsSetSelectionMode()
        {
            return this._selectionMode != null;
        }

    }
}