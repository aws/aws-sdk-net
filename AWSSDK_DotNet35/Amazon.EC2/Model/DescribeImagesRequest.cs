/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeImages operation.
    /// <para> The DescribeImages operation returns information about AMIs, AKIs, and ARIs available to the user. Information returned includes
    /// image type, product codes, architecture, and kernel and RAM disk IDs. Images available to the user include public images available for any
    /// user to launch, private images owned by the user making the request, and private images owned by other users for which the user has explicit
    /// launch permissions. </para> <para> Launch permissions fall into three categories: </para>
    /// <ul>
    /// <li> <b>Public:</b> The owner of the AMI granted launch permissions for the AMI to the all group. All users have launch permissions for
    /// these AMIs. </li>
    /// <li> <b>Explicit:</b> The owner of the AMI granted launch permissions to a specific user. </li>
    /// <li> <b>Implicit:</b> A user has implicit launch permissions for all AMIs he or she owns. </li>
    /// 
    /// </ul>
    /// <para> The list of AMIs returned can be modified by specifying AMI IDs, AMI owners, or users with launch permissions. If no options are
    /// specified, Amazon EC2 returns all AMIs for which the user has launch permissions. </para> <para> If you specify one or more AMI IDs, only
    /// AMIs that have the specified IDs are returned. If you specify an invalid AMI ID, a fault is returned. If you specify an AMI ID for which you
    /// do not have access, it will not be included in the returned results. </para> <para> If you specify one or more AMI owners, only AMIs from
    /// the specified owners and for which you have access are returned. The results can include the account IDs of the specified owners, amazon for
    /// AMIs owned by Amazon or self for AMIs that you own. </para> <para> If you specify a list of executable users, only users that have launch
    /// permissions for the AMIs are returned. You can specify account IDs (if you own the AMI(s)), self for AMIs for which you own or have explicit
    /// permissions, or all for public AMIs. </para> <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified
    /// interval after deregistration. </para>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonEC2Request
    {
        private List<string> imageIds = new List<string>();
        private List<string> owners = new List<string>();
        private List<string> executableUsers = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// An optional list of the AMI IDs to describe. If not specified, all AMIs will be described.
        ///  
        /// </summary>
        public List<string> ImageIds
        {
            get { return this.imageIds; }
            set { this.imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this.imageIds.Count > 0;
        }

        /// <summary>
        /// An optional list of owners by which to scope the described AMIs. Valid values are: <ul> <li> <c>self</c> : AMIs owned by you </li> <li>
        /// <i>AWS account ID</i> : AMIs owned by this account ID </li> <li> <c>aws-marketplace</c> : AMIs owned by the AWS Marketplace </li> <li>
        /// <c>amazon</c> : AMIs owned by Amazon </li> <li> <c>all</c> : Do not scope the AMIs returned by owner </li> </ul> The values <c>self</c>,
        /// <c>aws-marketplace</c>, <c>amazon</c>, and <c>all</c> are literals.
        ///  
        /// </summary>
        public List<string> Owners
        {
            get { return this.owners; }
            set { this.owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this.owners.Count > 0;
        }

        /// <summary>
        /// An optional list of users whose launch permissions will be used to scope the described AMIs. Valid values are: <ul> <li> <c>self</c> : AMIs
        /// for which you have explicit launch permissions </li> <li> <c>AWS account ID</c> : AMIs for which this account ID has launch permissions
        /// </li> <li> <c>all</c> : AMIs that have public launch permissions </li> </ul> The values <c>self</c> and <c>all</c> are literals.
        ///  
        /// </summary>
        public List<string> ExecutableUsers
        {
            get { return this.executableUsers; }
            set { this.executableUsers = value; }
        }

        // Check to see if ExecutableUsers property is set
        internal bool IsSetExecutableUsers()
        {
            return this.executableUsers.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for Images. For a complete reference to the available filter keys for this operation, see the <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
