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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The schema summary for the objects listed by the request.
    /// </summary>
    public partial class SchemaSummary
    {
        private AnalysisMethod _analysisMethod;
        private List<string> _analysisRuleTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _collaborationArn;
        private string _collaborationId;
        private DateTime? _createTime;
        private string _creatorAccountId;
        private string _name;
        private List<string> _selectedAnalysisMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SchemaType _type;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AnalysisMethod. 
        /// <para>
        /// The analysis method for the associated schema.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_QUERY</c> allows SQL queries to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_JOB</c> allows PySpark jobs to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>MULTIPLE</c> allows both SQL queries and PySpark jobs to be run directly on this
        /// table.
        /// </para>
        /// </summary>
        public AnalysisMethod AnalysisMethod
        {
            get { return this._analysisMethod; }
            set { this._analysisMethod = value; }
        }

        // Check to see if AnalysisMethod property is set
        internal bool IsSetAnalysisMethod()
        {
            return this._analysisMethod != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisRuleTypes. 
        /// <para>
        /// The types of analysis rules that are associated with this schema object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AnalysisRuleTypes
        {
            get { return this._analysisRuleTypes; }
            set { this._analysisRuleTypes = value; }
        }

        // Check to see if AnalysisRuleTypes property is set
        internal bool IsSetAnalysisRuleTypes()
        {
            return this._analysisRuleTypes != null && (this._analysisRuleTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The unique ARN for the collaboration that the schema belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string CollaborationArn
        {
            get { return this._collaborationArn; }
            set { this._collaborationArn = value; }
        }

        // Check to see if CollaborationArn property is set
        internal bool IsSetCollaborationArn()
        {
            return this._collaborationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique ID for the collaboration that the schema belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationId
        {
            get { return this._collaborationId; }
            set { this._collaborationId = value; }
        }

        // Check to see if CollaborationId property is set
        internal bool IsSetCollaborationId()
        {
            return this._collaborationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the schema object was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The unique account ID for the Amazon Web Services account that owns the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CreatorAccountId
        {
            get { return this._creatorAccountId; }
            set { this._creatorAccountId = value; }
        }

        // Check to see if CreatorAccountId property is set
        internal bool IsSetCreatorAccountId()
        {
            return this._creatorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the schema object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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
        /// Gets and sets the property SelectedAnalysisMethods. 
        /// <para>
        ///  The selected analysis methods for the schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedAnalysisMethods
        {
            get { return this._selectedAnalysisMethods; }
            set { this._selectedAnalysisMethods = value; }
        }

        // Check to see if SelectedAnalysisMethods property is set
        internal bool IsSetSelectedAnalysisMethods()
        {
            return this._selectedAnalysisMethods != null && (this._selectedAnalysisMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of schema object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the schema object was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}