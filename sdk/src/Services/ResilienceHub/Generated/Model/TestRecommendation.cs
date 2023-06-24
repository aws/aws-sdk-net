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
    /// Defines a test recommendation.
    /// </summary>
    public partial class TestRecommendation
    {
        private string _appComponentName;
        private List<string> _dependsOnAlarms = new List<string>();
        private string _description;
        private string _intent;
        private List<RecommendationItem> _items = new List<RecommendationItem>();
        private string _name;
        private string _prerequisite;
        private string _recommendationId;
        private string _referenceId;
        private TestRisk _risk;
        private TestType _type;

        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// The name of the Application Component.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DependsOnAlarms. 
        /// <para>
        ///  A list of recommended alarms that are used in the test and must be exported before
        /// or with the test. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<string> DependsOnAlarms
        {
            get { return this._dependsOnAlarms; }
            set { this._dependsOnAlarms = value; }
        }

        // Check to see if DependsOnAlarms property is set
        internal bool IsSetDependsOnAlarms()
        {
            return this._dependsOnAlarms != null && this._dependsOnAlarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the test recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property Intent. 
        /// <para>
        /// The intent of the test recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The test recommendation items.
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
        /// The name of the test recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// The prerequisite of the test recommendation.
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
        /// Identifier for the test recommendation.
        /// </para>
        /// </summary>
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
        /// The reference identifier for the test recommendation.
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
        /// Gets and sets the property Risk. 
        /// <para>
        /// The level of risk for this test recommendation.
        /// </para>
        /// </summary>
        public TestRisk Risk
        {
            get { return this._risk; }
            set { this._risk = value; }
        }

        // Check to see if Risk property is set
        internal bool IsSetRisk()
        {
            return this._risk != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of test recommendation.
        /// </para>
        /// </summary>
        public TestType Type
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