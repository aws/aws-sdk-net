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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Recommendation information to help you remediate detected anomalous behavior that
    /// generated an insight.
    /// </summary>
    public partial class Recommendation
    {
        private string _description;
        private string _link;
        private string _name;
        private string _reason;
        private List<RecommendationRelatedAnomaly> _relatedAnomalies = new List<RecommendationRelatedAnomaly>();
        private List<RecommendationRelatedEvent> _relatedEvents = new List<RecommendationRelatedEvent>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the problem. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Link. 
        /// <para>
        ///  A hyperlink to information to help you address the problem. 
        /// </para>
        /// </summary>
        public string Link
        {
            get { return this._link; }
            set { this._link = value; }
        }

        // Check to see if Link property is set
        internal bool IsSetLink()
        {
            return this._link != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the recommendation. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Reason. 
        /// <para>
        ///  The reason DevOps Guru flagged the anomalous behavior as a problem. 
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedAnomalies. 
        /// <para>
        ///  Anomalies that are related to the problem. Use these Anomalies to learn more about
        /// what's happening and to help address the issue. 
        /// </para>
        /// </summary>
        public List<RecommendationRelatedAnomaly> RelatedAnomalies
        {
            get { return this._relatedAnomalies; }
            set { this._relatedAnomalies = value; }
        }

        // Check to see if RelatedAnomalies property is set
        internal bool IsSetRelatedAnomalies()
        {
            return this._relatedAnomalies != null && this._relatedAnomalies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RelatedEvents. 
        /// <para>
        ///  Events that are related to the problem. Use these events to learn more about what's
        /// happening and to help address the issue. 
        /// </para>
        /// </summary>
        public List<RecommendationRelatedEvent> RelatedEvents
        {
            get { return this._relatedEvents; }
            set { this._relatedEvents = value; }
        }

        // Check to see if RelatedEvents property is set
        internal bool IsSetRelatedEvents()
        {
            return this._relatedEvents != null && this._relatedEvents.Count > 0; 
        }

    }
}