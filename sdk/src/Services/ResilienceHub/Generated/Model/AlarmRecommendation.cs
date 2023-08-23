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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a recommendation for a CloudWatch alarm.
    /// </summary>
    public partial class AlarmRecommendation
    {
        private string _appComponentName;
        private List<string> _appComponentNames = new List<string>();
        private string _description;
        private List<RecommendationItem> _items = new List<RecommendationItem>();
        private string _name;
        private string _prerequisite;
        private string _recommendationId;
        private string _referenceId;
        private AlarmType _type;

        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// Application Component name for the CloudWatch alarm recommendation. This name is saved
        /// as the first item in the <code>appComponentNames</code> list.
        /// </para>
        /// </summary>
        [Obsolete("An alarm recommendation can be attached to multiple Application Components, hence this property will be replaced by the new property 'appComponentNames'.")]
        public string AppComponentName
        {
            get { return this._appComponentName; }
            set { this._appComponentName = value; }
        }

        // Check to see if AppComponentName property is set
        internal bool IsSetAppComponentName()
        {
            return this._appComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property AppComponentNames. 
        /// <para>
        /// List of Application Component names for the CloudWatch alarm recommendation.
        /// </para>
        /// </summary>
        public List<string> AppComponentNames
        {
            get { return this._appComponentNames; }
            set { this._appComponentNames = value; }
        }

        // Check to see if AppComponentNames property is set
        internal bool IsSetAppComponentNames()
        {
            return this._appComponentNames != null && this._appComponentNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the alarm recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property Items. 
        /// <para>
        /// List of CloudWatch alarm recommendations.
        /// </para>
        /// </summary>
        public List<RecommendationItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the alarm recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
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
        /// Gets and sets the property Prerequisite. 
        /// <para>
        /// The prerequisite for the alarm recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Prerequisite
        {
            get { return this._prerequisite; }
            set { this._prerequisite = value; }
        }

        // Check to see if Prerequisite property is set
        internal bool IsSetPrerequisite()
        {
            return this._prerequisite != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// Identifier of the alarm recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Reference identifier of the alarm recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of alarm recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlarmType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}