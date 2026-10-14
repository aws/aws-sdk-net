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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN that specifies the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssetAttributes. 
        /// <para>
        /// A collection of attributes of the host from which the finding is generated.
        /// </para>
        /// </summary>
        public AssetAttributes AssetAttributes { get; set; }

        /// <summary>
        /// Checks to see if the AssetAttributes property is set.
        /// </summary>
        internal bool IsSetAssetAttributes() => this.AssetAttributes != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of the host from which the finding is generated.
        /// </para>
        /// </summary>
        public AssetType AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The system-defined attributes for the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<Attribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// This data element is currently not used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the finding was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IndicatorOfCompromise. 
        /// <para>
        /// This data element is currently not used.
        /// </para>
        /// </summary>
        public bool? IndicatorOfCompromise { get; set; }

        /// <summary>
        /// Checks to see if the IndicatorOfCompromise property is set.
        /// </summary>
        internal bool IsSetIndicatorOfCompromise() => this.IndicatorOfCompromise.HasValue;

        /// <summary>
        /// Gets and sets the property NumericSeverity. 
        /// <para>
        /// The numeric value of the finding severity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public double? NumericSeverity { get; set; }

        /// <summary>
        /// Checks to see if the NumericSeverity property is set.
        /// </summary>
        internal bool IsSetNumericSeverity() => this.NumericSeverity.HasValue;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommendation for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of this data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The data element is set to "Inspector".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceAttributes. 
        /// <para>
        /// This data type is used in the <a>Finding</a> data type.
        /// </para>
        /// </summary>
        public InspectorServiceAttributes ServiceAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAttributes property is set.
        /// </summary>
        internal bool IsSetServiceAttributes() => this.ServiceAttributes != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The finding severity. Values can be set to High, Medium, Low, and Informational.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The name of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when <a>AddAttributesToFindings</a> is called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// The user-defined attributes that are assigned to the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<Attribute> UserAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the UserAttributes property is set.
        /// </summary>
        internal bool IsSetUserAttributes() => this.UserAttributes != null && (this.UserAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
