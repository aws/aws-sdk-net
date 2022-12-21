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
    /// </summary>
    public partial class DescribeImagesRequest : AmazonEC2Request
    {
        private List<string> _executableUsers = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private List<string> _imageIds = new List<string>();
        private bool? _includeDeprecated;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _owners = new List<string>();

        /// <summary>
        /// Gets and sets the property ExecutableUsers. 
        /// <para>
        /// Scopes the images by users with explicit launch permissions. Specify an Amazon Web
        /// Services account ID, <code>self</code> (the sender of the request), or <code>all</code>
        /// (public AMIs).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify an Amazon Web Services account ID that is not your own, only AMIs shared
        /// with that specific Amazon Web Services account ID are returned. However, AMIs that
        /// are shared with the account’s organization or organizational unit (OU) are not returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>self</code> or your own Amazon Web Services account ID, AMIs
        /// shared with your account are returned. In addition, AMIs that are shared with the
        /// organization or OU of which you are member are also returned. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>all</code>, all public AMIs are returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> ExecutableUsers
        {
            get { return this._executableUsers; }
            set { this._executableUsers = value; }
        }

        // Check to see if ExecutableUsers property is set
        internal bool IsSetExecutableUsers()
        {
            return this._executableUsers != null && this._executableUsers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>architecture</code> - The image architecture (<code>i386</code> | <code>x86_64</code>
        /// | <code>arm64</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.delete-on-termination</code> - A Boolean value that indicates
        /// whether the Amazon EBS volume is deleted on instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.device-name</code> - The device name specified in the
        /// block device mapping (for example, <code>/dev/sdh</code> or <code>xvdh</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.snapshot-id</code> - The ID of the snapshot used for the
        /// Amazon EBS volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.volume-size</code> - The volume size of the Amazon EBS
        /// volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.volume-type</code> - The volume type of the Amazon EBS
        /// volume (<code>io1</code> | <code>io2</code> | <code>gp2</code> | <code>gp3</code>
        /// | <code>sc1 </code>| <code>st1</code> | <code>standard</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.encrypted</code> - A Boolean that indicates whether the
        /// Amazon EBS volume is encrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>creation-date</code> - The time when the image was created, in the ISO 8601
        /// format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ), for example, <code>2021-09-29T11:04:43.305Z</code>.
        /// You can use a wildcard (<code>*</code>), for example, <code>2021-09-29T*</code>, which
        /// matches an entire day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>description</code> - The description of the image (provided during image creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ena-support</code> - A Boolean that indicates whether enhanced networking with
        /// ENA is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>hypervisor</code> - The hypervisor type (<code>ovm</code> | <code>xen</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>image-id</code> - The ID of the image.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>image-type</code> - The image type (<code>machine</code> | <code>kernel</code>
        /// | <code>ramdisk</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>is-public</code> - A Boolean that indicates whether the image is public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kernel-id</code> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>manifest-location</code> - The location of the image manifest.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code> - The name of the AMI (provided during image creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-alias</code> - The owner alias (<code>amazon</code> | <code>aws-marketplace</code>).
        /// The valid aliases are defined in an Amazon-maintained list. This is not the Amazon
        /// Web Services account alias that can be set using the IAM console. We recommend that
        /// you use the <b>Owner</b> request parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The Amazon Web Services account ID of the owner. We recommend
        /// that you use the <b>Owner</b> request parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>platform</code> - The platform. The only supported value is <code>windows</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-code</code> - The product code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-code.type</code> - The type of the product code (<code>marketplace</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ramdisk-id</code> - The RAM disk ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>root-device-name</code> - The device name of the root device volume (for example,
        /// <code>/dev/sda1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>root-device-type</code> - The type of the root device volume (<code>ebs</code>
        /// | <code>instance-store</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the image (<code>available</code> | <code>pending</code>
        /// | <code>failed</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state-reason-code</code> - The reason code for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state-reason-message</code> - The message for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sriov-net-support</code> - A value of <code>simple</code> indicates that enhanced
        /// networking with the Intel 82599 VF interface is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>virtualization-type</code> - The virtualization type (<code>paravirtual</code>
        /// | <code>hvm</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
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
        /// </summary>
        public List<string> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && this._imageIds.Count > 0; 
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
        public bool IncludeDeprecated
        {
            get { return this._includeDeprecated.GetValueOrDefault(); }
            set { this._includeDeprecated = value; }
        }

        // Check to see if IncludeDeprecated property is set
        internal bool IsSetIncludeDeprecated()
        {
            return this._includeDeprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token for the next page of results.
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
        /// of Amazon Web Services account IDs, <code>self</code>, <code>amazon</code>, and <code>aws-marketplace</code>.
        /// If you omit this parameter, the results include all images for which you have launch
        /// permissions, regardless of ownership.
        /// </para>
        /// </summary>
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && this._owners.Count > 0; 
        }

    }
}