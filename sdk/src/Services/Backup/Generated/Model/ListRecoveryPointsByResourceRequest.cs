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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecoveryPointsByResource operation.
    /// The information about the recovery points of the type specified by a resource Amazon
    /// Resource Name (ARN).
    /// 
    ///  <note> 
    /// <para>
    /// For Amazon EFS and Amazon EC2, this action only lists recovery points created by Backup.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListRecoveryPointsByResourceRequest : AmazonBackupRequest
    {
        private bool? _managedByAWSBackupOnly;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ManagedByAWSBackupOnly. 
        /// <para>
        /// This attribute filters recovery points based on ownership.
        /// </para>
        ///  
        /// <para>
        /// If this is set to <c>TRUE</c>, the response will contain recovery points associated
        /// with the selected resources that are managed by Backup.
        /// </para>
        ///  
        /// <para>
        /// If this is set to <c>FALSE</c>, the response will contain all recovery points associated
        /// with the selected resource.
        /// </para>
        ///  
        /// <para>
        /// Type: Boolean
        /// </para>
        /// </summary>
        public bool ManagedByAWSBackupOnly
        {
            get { return this._managedByAWSBackupOnly.GetValueOrDefault(); }
            set { this._managedByAWSBackupOnly = value; }
        }

        // Check to see if ManagedByAWSBackupOnly property is set
        internal bool IsSetManagedByAWSBackupOnly()
        {
            return this._managedByAWSBackupOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be returned.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon RDS requires a value of at least 20.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <c>MaxResults</c> number of items, <c>NextToken</c> allows you to
        /// return more items in your list starting at the location pointed to by the next token.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies a resource. The format of the ARN depends on the resource
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}