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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains details about the protected query output.
    /// </summary>
    public partial class ProtectedQueryOutput
    {
        private ProtectedQueryDistributeOutput _distribute;
        private List<ProtectedQuerySingleMemberOutput> _memberList = AWSConfigs.InitializeCollections ? new List<ProtectedQuerySingleMemberOutput>() : null;
        private ProtectedQueryS3Output _s3;

        /// <summary>
        /// Gets and sets the property Distribute. 
        /// <para>
        /// Contains output information for protected queries that use a <c>distribute</c> output
        /// type. This output type lets you send query results to multiple locations - either
        /// to S3 or to collaboration members. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You can only use the <c>distribute</c> output type with the Spark analytics engine.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public ProtectedQueryDistributeOutput Distribute
        {
            get { return this._distribute; }
            set { this._distribute = value; }
        }

        // Check to see if Distribute property is set
        internal bool IsSetDistribute()
        {
            return this._distribute != null;
        }

        /// <summary>
        /// Gets and sets the property MemberList. 
        /// <para>
        /// The list of member Amazon Web Services account(s) that received the results of the
        /// query. 
        /// </para>
        /// </summary>
        public List<ProtectedQuerySingleMemberOutput> MemberList
        {
            get { return this._memberList; }
            set { this._memberList = value; }
        }

        // Check to see if MemberList property is set
        internal bool IsSetMemberList()
        {
            return this._memberList != null && (this._memberList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// If present, the output for a protected query with an <c>S3</c> output type.
        /// </para>
        /// </summary>
        public ProtectedQueryS3Output S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}