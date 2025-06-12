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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a CloudFormation stack record created as a result of the <c>create cloud
    /// formation stack</c> action.
    /// 
    ///  
    /// <para>
    /// A CloudFormation stack record provides information about the AWS CloudFormation stack
    /// used to create a new Amazon Elastic Compute Cloud instance from an exported Lightsail
    /// instance snapshot.
    /// </para>
    /// </summary>
    public partial class CloudFormationStackRecord
    {
        private string _arn;
        private DateTime? _createdAt;
        private DestinationInfo _destinationInfo;
        private ResourceLocation _location;
        private string _name;
        private ResourceType _resourceType;
        private List<CloudFormationStackRecordSourceInfo> _sourceInfo = AWSConfigs.InitializeCollections ? new List<CloudFormationStackRecordSourceInfo>() : null;
        private RecordState _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudFormation stack record.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the CloudFormation stack record was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DestinationInfo. 
        /// <para>
        /// A list of objects describing the destination service, which is AWS CloudFormation,
        /// and the Amazon Resource Name (ARN) of the AWS CloudFormation stack.
        /// </para>
        /// </summary>
        public DestinationInfo DestinationInfo
        {
            get { return this._destinationInfo; }
            set { this._destinationInfo = value; }
        }

        // Check to see if DestinationInfo property is set
        internal bool IsSetDestinationInfo()
        {
            return this._destinationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A list of objects describing the Availability Zone and Amazon Web Services Region
        /// of the CloudFormation stack record.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the CloudFormation stack record. It starts with <c>CloudFormationStackRecord</c>
        /// followed by a GUID.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (<c>CloudFormationStackRecord</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType
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
        /// Gets and sets the property SourceInfo. 
        /// <para>
        /// A list of objects describing the source of the CloudFormation stack record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudFormationStackRecordSourceInfo> SourceInfo
        {
            get { return this._sourceInfo; }
            set { this._sourceInfo = value; }
        }

        // Check to see if SourceInfo property is set
        internal bool IsSetSourceInfo()
        {
            return this._sourceInfo != null && (this._sourceInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the CloudFormation stack record.
        /// </para>
        /// </summary>
        public RecordState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}