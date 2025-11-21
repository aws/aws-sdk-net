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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeImageReferences operation.
    /// Describes your Amazon Web Services resources that are referencing the specified images.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-ami-references.html">Identify
    /// your resources referencing specified AMIs</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeImageReferencesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _imageIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _includeAllResourceTypes;
        private int? _maxResults;
        private string _nextToken;
        private List<ResourceTypeRequest> _resourceTypes = AWSConfigs.InitializeCollections ? new List<ResourceTypeRequest>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The IDs of the images to check for resource references.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && (this._imageIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeAllResourceTypes. 
        /// <para>
        /// Specifies whether to check all supported Amazon Web Services resource types for image
        /// references. When specified, default values are applied for <c>ResourceTypeOptions</c>.
        /// For the default values, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-ami-references.html#how-ami-references-works">How
        /// AMI reference checks work</a> in the <i>Amazon EC2 User Guide</i>. If you also specify
        /// <c>ResourceTypes</c> with <c>ResourceTypeOptions</c>, your specified values override
        /// the default values.
        /// </para>
        ///  
        /// <para>
        /// Supported resource types: <c>ec2:Instance</c> | <c>ec2:LaunchTemplate</c> | <c>ssm:Parameter</c>
        /// | <c>imagebuilder:ImageRecipe</c> | <c>imagebuilder:ContainerRecipe</c> 
        /// </para>
        ///  
        /// <para>
        /// Either <c>IncludeAllResourceTypes</c> or <c>ResourceTypes</c> must be specified.
        /// </para>
        /// </summary>
        public bool? IncludeAllResourceTypes
        {
            get { return this._includeAllResourceTypes; }
            set { this._includeAllResourceTypes = value; }
        }

        // Check to see if IncludeAllResourceTypes property is set
        internal bool IsSetIncludeAllResourceTypes()
        {
            return this._includeAllResourceTypes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The Amazon Web Services resource types to check for image references.
        /// </para>
        ///  
        /// <para>
        /// Either <c>IncludeAllResourceTypes</c> or <c>ResourceTypes</c> must be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceTypeRequest> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}