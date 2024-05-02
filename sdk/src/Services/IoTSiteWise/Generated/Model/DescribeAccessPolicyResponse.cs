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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccessPolicy operation.
    /// </summary>
    public partial class DescribeAccessPolicyResponse : AmazonWebServiceResponse
    {
        private string _accessPolicyArn;
        private DateTime? _accessPolicyCreationDate;
        private string _accessPolicyId;
        private Identity _accessPolicyIdentity;
        private DateTime? _accessPolicyLastUpdateDate;
        private Permission _accessPolicyPermission;
        private Resource _accessPolicyResource;

        /// <summary>
        /// Gets and sets the property AccessPolicyArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the access policy, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:access-policy/${AccessPolicyId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AccessPolicyArn
        {
            get { return this._accessPolicyArn; }
            set { this._accessPolicyArn = value; }
        }

        // Check to see if AccessPolicyArn property is set
        internal bool IsSetAccessPolicyArn()
        {
            return this._accessPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyCreationDate. 
        /// <para>
        /// The date the access policy was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AccessPolicyCreationDate
        {
            get { return this._accessPolicyCreationDate; }
            set { this._accessPolicyCreationDate = value; }
        }

        // Check to see if AccessPolicyCreationDate property is set
        internal bool IsSetAccessPolicyCreationDate()
        {
            return this._accessPolicyCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyId. 
        /// <para>
        /// The ID of the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AccessPolicyId
        {
            get { return this._accessPolicyId; }
            set { this._accessPolicyId = value; }
        }

        // Check to see if AccessPolicyId property is set
        internal bool IsSetAccessPolicyId()
        {
            return this._accessPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyIdentity. 
        /// <para>
        /// The identity (IAM Identity Center user, IAM Identity Center group, or IAM user) to
        /// which this access policy applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Identity AccessPolicyIdentity
        {
            get { return this._accessPolicyIdentity; }
            set { this._accessPolicyIdentity = value; }
        }

        // Check to see if AccessPolicyIdentity property is set
        internal bool IsSetAccessPolicyIdentity()
        {
            return this._accessPolicyIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyLastUpdateDate. 
        /// <para>
        /// The date the access policy was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AccessPolicyLastUpdateDate
        {
            get { return this._accessPolicyLastUpdateDate; }
            set { this._accessPolicyLastUpdateDate = value; }
        }

        // Check to see if AccessPolicyLastUpdateDate property is set
        internal bool IsSetAccessPolicyLastUpdateDate()
        {
            return this._accessPolicyLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyPermission. 
        /// <para>
        /// The access policy permission. Note that a project <c>ADMINISTRATOR</c> is also known
        /// as a project owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Permission AccessPolicyPermission
        {
            get { return this._accessPolicyPermission; }
            set { this._accessPolicyPermission = value; }
        }

        // Check to see if AccessPolicyPermission property is set
        internal bool IsSetAccessPolicyPermission()
        {
            return this._accessPolicyPermission != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPolicyResource. 
        /// <para>
        /// The IoT SiteWise Monitor resource (portal or project) to which this access policy
        /// provides access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Resource AccessPolicyResource
        {
            get { return this._accessPolicyResource; }
            set { this._accessPolicyResource = value; }
        }

        // Check to see if AccessPolicyResource property is set
        internal bool IsSetAccessPolicyResource()
        {
            return this._accessPolicyResource != null;
        }

    }
}