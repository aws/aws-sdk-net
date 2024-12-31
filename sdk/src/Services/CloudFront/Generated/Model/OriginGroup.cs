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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An origin group includes two origins (a primary origin and a secondary origin to failover
    /// to) and a failover criteria that you specify. You create an origin group to support
    /// origin failover in CloudFront. When you create or update a distribution, you can specify
    /// the origin group instead of a single origin, and CloudFront will failover from the
    /// primary origin to the secondary origin under the failover conditions that you've chosen.
    /// 
    ///  
    /// <para>
    /// Optionally, you can choose selection criteria for your origin group to specify how
    /// your origins are selected when your distribution routes viewer requests.
    /// </para>
    /// </summary>
    public partial class OriginGroup
    {
        private OriginGroupFailoverCriteria _failoverCriteria;
        private string _id;
        private OriginGroupMembers _members;
        private OriginGroupSelectionCriteria _selectionCriteria;

        /// <summary>
        /// Gets and sets the property FailoverCriteria. 
        /// <para>
        /// A complex type that contains information about the failover criteria for an origin
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginGroupFailoverCriteria FailoverCriteria
        {
            get { return this._failoverCriteria; }
            set { this._failoverCriteria = value; }
        }

        // Check to see if FailoverCriteria property is set
        internal bool IsSetFailoverCriteria()
        {
            return this._failoverCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The origin group's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Members. 
        /// <para>
        /// A complex type that contains information about the origins in an origin group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginGroupMembers Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionCriteria. 
        /// <para>
        /// The selection criteria for the origin group. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/high_availability_origin_failover.html#concept_origin_groups.creating">Create
        /// an origin group</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public OriginGroupSelectionCriteria SelectionCriteria
        {
            get { return this._selectionCriteria; }
            set { this._selectionCriteria = value; }
        }

        // Check to see if SelectionCriteria property is set
        internal bool IsSetSelectionCriteria()
        {
            return this._selectionCriteria != null;
        }

    }
}