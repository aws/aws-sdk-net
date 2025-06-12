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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns details of a conformance pack. A conformance pack is a collection of Config
    /// rules and remediation actions that can be easily deployed in an account and a region.
    /// </summary>
    public partial class ConformancePackDetail
    {
        private string _conformancePackArn;
        private string _conformancePackId;
        private List<ConformancePackInputParameter> _conformancePackInputParameters = AWSConfigs.InitializeCollections ? new List<ConformancePackInputParameter>() : null;
        private string _conformancePackName;
        private string _createdBy;
        private string _deliveryS3Bucket;
        private string _deliveryS3KeyPrefix;
        private DateTime? _lastUpdateRequestedTime;
        private TemplateSSMDocumentDetails _templateSSMDocumentDetails;

        /// <summary>
        /// Gets and sets the property ConformancePackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConformancePackArn
        {
            get { return this._conformancePackArn; }
            set { this._conformancePackArn = value; }
        }

        // Check to see if ConformancePackArn property is set
        internal bool IsSetConformancePackArn()
        {
            return this._conformancePackArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackId. 
        /// <para>
        /// ID of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ConformancePackId
        {
            get { return this._conformancePackId; }
            set { this._conformancePackId = value; }
        }

        // Check to see if ConformancePackId property is set
        internal bool IsSetConformancePackId()
        {
            return this._conformancePackId != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <c>ConformancePackInputParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters
        {
            get { return this._conformancePackInputParameters; }
            set { this._conformancePackInputParameters = value; }
        }

        // Check to see if ConformancePackInputParameters property is set
        internal bool IsSetConformancePackInputParameters()
        {
            return this._conformancePackInputParameters != null && (this._conformancePackInputParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Web Services service that created the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where Config stores conformance pack templates. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string DeliveryS3Bucket
        {
            get { return this._deliveryS3Bucket; }
            set { this._deliveryS3Bucket = value; }
        }

        // Check to see if DeliveryS3Bucket property is set
        internal bool IsSetDeliveryS3Bucket()
        {
            return this._deliveryS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3KeyPrefix. 
        /// <para>
        /// The prefix for the Amazon S3 bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DeliveryS3KeyPrefix
        {
            get { return this._deliveryS3KeyPrefix; }
            set { this._deliveryS3KeyPrefix = value; }
        }

        // Check to see if DeliveryS3KeyPrefix property is set
        internal bool IsSetDeliveryS3KeyPrefix()
        {
            return this._deliveryS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateRequestedTime. 
        /// <para>
        /// The last time a conformation pack update was requested. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdateRequestedTime
        {
            get { return this._lastUpdateRequestedTime; }
            set { this._lastUpdateRequestedTime = value; }
        }

        // Check to see if LastUpdateRequestedTime property is set
        internal bool IsSetLastUpdateRequestedTime()
        {
            return this._lastUpdateRequestedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemplateSSMDocumentDetails. 
        /// <para>
        /// An object that contains the name or Amazon Resource Name (ARN) of the Amazon Web Services
        /// Systems Manager document (SSM document) and the version of the SSM document that is
        /// used to create a conformance pack.
        /// </para>
        /// </summary>
        public TemplateSSMDocumentDetails TemplateSSMDocumentDetails
        {
            get { return this._templateSSMDocumentDetails; }
            set { this._templateSSMDocumentDetails = value; }
        }

        // Check to see if TemplateSSMDocumentDetails property is set
        internal bool IsSetTemplateSSMDocumentDetails()
        {
            return this._templateSSMDocumentDetails != null;
        }

    }
}