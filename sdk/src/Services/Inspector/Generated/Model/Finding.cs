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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Amazon Inspector finding. This data type is used as
    /// the response element in the <a>DescribeFindings</a> action.
    /// </summary>
    public partial class Finding
    {
        private string _arn;
        private AssetAttributes _assetAttributes;
        private AssetType _assetType;
        private List<Attribute> _attributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;
        private int? _confidence;
        private DateTime? _createdAt;
        private string _description;
        private string _id;
        private bool? _indicatorOfCompromise;
        private double? _numericSeverity;
        private string _recommendation;
        private int? _schemaVersion;
        private string _service;
        private InspectorServiceAttributes _serviceAttributes;
        private Severity _severity;
        private string _title;
        private DateTime? _updatedAt;
        private List<Attribute> _userAttributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN that specifies the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetAttributes. 
        /// <para>
        /// A collection of attributes of the host from which the finding is generated.
        /// </para>
        /// </summary>
        public AssetAttributes AssetAttributes
        {
            get { return this._assetAttributes; }
            set { this._assetAttributes = value; }
        }

        // Check to see if AssetAttributes property is set
        internal bool IsSetAssetAttributes()
        {
            return this._assetAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of the host from which the finding is generated.
        /// </para>
        /// </summary>
        public AssetType AssetType
        {
            get { return this._assetType; }
            set { this._assetType = value; }
        }

        // Check to see if AssetType property is set
        internal bool IsSetAssetType()
        {
            return this._assetType != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The system-defined attributes for the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// This data element is currently not used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the finding was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20000)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IndicatorOfCompromise. 
        /// <para>
        /// This data element is currently not used.
        /// </para>
        /// </summary>
        public bool? IndicatorOfCompromise
        {
            get { return this._indicatorOfCompromise; }
            set { this._indicatorOfCompromise = value; }
        }

        // Check to see if IndicatorOfCompromise property is set
        internal bool IsSetIndicatorOfCompromise()
        {
            return this._indicatorOfCompromise.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumericSeverity. 
        /// <para>
        /// The numeric value of the finding severity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public double? NumericSeverity
        {
            get { return this._numericSeverity; }
            set { this._numericSeverity = value; }
        }

        // Check to see if NumericSeverity property is set
        internal bool IsSetNumericSeverity()
        {
            return this._numericSeverity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommendation for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20000)]
        public string Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of this data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The data element is set to "Inspector".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAttributes. 
        /// <para>
        /// This data type is used in the <a>Finding</a> data type.
        /// </para>
        /// </summary>
        public InspectorServiceAttributes ServiceAttributes
        {
            get { return this._serviceAttributes; }
            set { this._serviceAttributes = value; }
        }

        // Check to see if ServiceAttributes property is set
        internal bool IsSetServiceAttributes()
        {
            return this._serviceAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The finding severity. Values can be set to High, Medium, Low, and Informational.
        /// </para>
        /// </summary>
        public Severity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The name of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20000)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when <a>AddAttributesToFindings</a> is called.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// The user-defined attributes that are assigned to the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<Attribute> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && (this._userAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}