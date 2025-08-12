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
    /// Container for the parameters to the DescribeImages operation.
    /// Describes the specified images (AMIs, AKIs, and ARIs) available to you or all of the
    /// images available to you.
    /// 
    ///  
    /// <para>
    /// The images available to you include public images, private images that you own, and
    /// private images owned by other Amazon Web Services accounts for which you have explicit
    /// launch permissions.
    /// </para>
    ///  
    /// <para>
    /// Recently deregistered images appear in the returned results for a short interval and
    /// then return empty results. After all instances that reference a deregistered AMI are
    /// terminated, specifying the ID of the image will eventually return an error indicating
    /// that the AMI ID cannot be found.
    /// </para>
    ///  
    /// <para>
    /// When Allowed AMIs is set to <c>enabled</c>, only allowed images are returned in the
    /// results, with the <c>imageAllowed</c> field set to <c>true</c> for each image. In
    /// <c>audit-mode</c>, the <c>imageAllowed</c> field is set to <c>true</c> for images
    /// that meet the account's Allowed AMIs criteria, and <c>false</c> for images that don't
    /// meet the criteria. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html">Allowed
    /// AMIs</a>.
    /// </para>
    ///  
    /// <para>
    /// The Amazon EC2 API follows an eventual consistency model. This means that the result
    /// of an API command you run that creates or modifies resources might not be immediately
    /// available to all subsequent commands you run. For guidance on how to manage eventual
    /// consistency, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/eventual-consistency.html">Eventual
    /// consistency in the Amazon EC2 API</a> in the <i>Amazon EC2 Developer Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly recommend using only paginated requests. Unpaginated requests are susceptible
    /// to throttling and timeouts.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _executableUsers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _imageIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _includeDeprecated;
        private bool? _includeDisabled;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _owners = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property ExecutableUsers. 
        /// <para>
        /// Scopes the images by users with explicit launch permissions. Specify an Amazon Web
        /// Services account ID, <c>self</c> (the sender of the request), or <c>all</c> (public
        /// AMIs).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify an Amazon Web Services account ID that is not your own, only AMIs shared
        /// with that specific Amazon Web Services account ID are returned. However, AMIs that
        /// are shared with the account’s organization or organizational unit (OU) are not returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>self</c> or your own Amazon Web Services account ID, AMIs shared
        /// with your account are returned. In addition, AMIs that are shared with the organization
        /// or OU of which you are member are also returned. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>all</c>, all public AMIs are returned.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExecutableUsers
        {
            get { return this._executableUsers; }
            set { this._executableUsers = value; }
        }

        // Check to see if ExecutableUsers property is set
        internal bool IsSetExecutableUsers()
        {
            return this._executableUsers != null && (this._executableUsers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>architecture</c> - The image architecture (<c>i386</c> | <c>x86_64</c> | <c>arm64</c>
        /// | <c>x86_64_mac</c> | <c>arm64_mac</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-device-mapping.delete-on-termination</c> - A Boolean value that indicates
        /// whether the Amazon EBS volume is deleted on instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-device-mapping.device-name</c> - The device name specified in the block
        /// device mapping (for example, <c>/dev/sdh</c> or <c>xvdh</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-device-mapping.snapshot-id</c> - The ID of the snapshot used for the Amazon
        /// EBS volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-device-mapping.volume-size</c> - The volume size of the Amazon EBS volume,
        /// in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-device-mapping.volume-type</c> - The volume type of the Amazon EBS volume
        /// (<c>io1</c> | <c>io2</c> | <c>gp2</c> | <c>gp3</c> | <c>sc1 </c>| <c>st1</c> | <c>standard</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-device-mapping.encrypted</c> - A Boolean that indicates whether the Amazon
        /// EBS volume is encrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>creation-date</c> - The time when the image was created, in the ISO 8601 format
        /// in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ), for example, <c>2021-09-29T11:04:43.305Z</c>.
        /// You can use a wildcard (<c>*</c>), for example, <c>2021-09-29T*</c>, which matches
        /// an entire day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>description</c> - The description of the image (provided during image creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ena-support</c> - A Boolean that indicates whether enhanced networking with ENA
        /// is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>free-tier-eligible</c> - A Boolean that indicates whether this image can be used
        /// under the Amazon Web Services Free Tier (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hypervisor</c> - The hypervisor type (<c>ovm</c> | <c>xen</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>image-allowed</c> - A Boolean that indicates whether the image meets the criteria
        /// specified for Allowed AMIs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>image-id</c> - The ID of the image.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>image-type</c> - The image type (<c>machine</c> | <c>kernel</c> | <c>ramdisk</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>is-public</c> - A Boolean that indicates whether the image is public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kernel-id</c> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manifest-location</c> - The location of the image manifest.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>name</c> - The name of the AMI (provided during image creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-alias</c> - The owner alias (<c>amazon</c> | <c>aws-backup-vault</c> | <c>aws-marketplace</c>).
        /// The valid aliases are defined in an Amazon-maintained list. This is not the Amazon
        /// Web Services account alias that can be set using the IAM console. We recommend that
        /// you use the <b>Owner</b> request parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The Amazon Web Services account ID of the owner. We recommend that
        /// you use the <b>Owner</b> request parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>platform</c> - The platform. The only supported value is <c>windows</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-code</c> - The product code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-code.type</c> - The type of the product code (<c>marketplace</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ramdisk-id</c> - The RAM disk ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>root-device-name</c> - The device name of the root device volume (for example,
        /// <c>/dev/sda1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>root-device-type</c> - The type of the root device volume (<c>ebs</c> | <c>instance-store</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-image-id</c> - The ID of the source AMI from which the AMI was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-image-region</c> - The Region of the source AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-instance-id</c> - The ID of the instance that the AMI was created from
        /// if the AMI was created using CreateImage. This filter is applicable only if the AMI
        /// was created using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateImage.html">CreateImage</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the image (<c>available</c> | <c>pending</c> | <c>failed</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state-reason-code</c> - The reason code for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state-reason-message</c> - The message for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sriov-net-support</c> - A value of <c>simple</c> indicates that enhanced networking
        /// with the Intel 82599 VF interface is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>virtualization-type</c> - The virtualization type (<c>paravirtual</c> | <c>hvm</c>).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The image IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all images available to you.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property IncludeDeprecated. 
        /// <para>
        /// Specifies whether to include deprecated AMIs.
        /// </para>
        ///  
        /// <para>
        /// Default: No deprecated AMIs are included in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are the AMI owner, all deprecated AMIs appear in the response regardless of
        /// what you specify for this parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? IncludeDeprecated
        {
            get { return this._includeDeprecated; }
            set { this._includeDeprecated = value; }
        }

        // Check to see if IncludeDeprecated property is set
        internal bool IsSetIncludeDeprecated()
        {
            return this._includeDeprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeDisabled. 
        /// <para>
        /// Specifies whether to include disabled AMIs.
        /// </para>
        ///  
        /// <para>
        /// Default: No disabled AMIs are included in the response.
        /// </para>
        /// </summary>
        public bool? IncludeDisabled
        {
            get { return this._includeDisabled; }
            set { this._includeDisabled = value; }
        }

        // Check to see if IncludeDisabled property is set
        internal bool IsSetIncludeDisabled()
        {
            return this._includeDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Owners. 
        /// <para>
        /// Scopes the results to images with the specified owners. You can specify a combination
        /// of Amazon Web Services account IDs, <c>self</c>, <c>amazon</c>, <c>aws-backup-vault</c>,
        /// and <c>aws-marketplace</c>. If you omit this parameter, the results include all images
        /// for which you have launch permissions, regardless of ownership.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && (this._owners.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}