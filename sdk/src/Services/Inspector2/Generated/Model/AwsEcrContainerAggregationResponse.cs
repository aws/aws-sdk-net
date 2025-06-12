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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An aggregation of information about Amazon ECR containers.
    /// </summary>
    public partial class AwsEcrContainerAggregationResponse
    {
        private string _accountId;
        private string _architecture;
        private string _imageSha;
        private List<string> _imageTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _inUseCount;
        private DateTime? _lastInUseAt;
        private string _repository;
        private string _resourceId;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account that owns the container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the container.
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSha. 
        /// <para>
        /// The SHA value of the container image.
        /// </para>
        /// </summary>
        public string ImageSha
        {
            get { return this._imageSha; }
            set { this._imageSha = value; }
        }

        // Check to see if ImageSha property is set
        internal bool IsSetImageSha()
        {
            return this._imageSha != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The container image stags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && (this._imageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InUseCount. 
        /// <para>
        /// The number of Amazon ECS tasks or Amazon EKS pods where the Amazon ECR container image
        /// is in use.
        /// </para>
        /// </summary>
        public long? InUseCount
        {
            get { return this._inUseCount; }
            set { this._inUseCount = value; }
        }

        // Check to see if InUseCount property is set
        internal bool IsSetInUseCount()
        {
            return this._inUseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastInUseAt. 
        /// <para>
        /// The last time an Amazon ECR image was used in an Amazon ECS task or Amazon EKS pod.
        /// </para>
        /// </summary>
        public DateTime? LastInUseAt
        {
            get { return this._lastInUseAt; }
            set { this._lastInUseAt = value; }
        }

        // Check to see if LastInUseAt property is set
        internal bool IsSetLastInUseAt()
        {
            return this._lastInUseAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The container repository.
        /// </para>
        /// </summary>
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID of the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// The number of finding by severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}