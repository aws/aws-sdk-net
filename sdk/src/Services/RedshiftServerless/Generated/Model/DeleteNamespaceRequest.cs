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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNamespace operation.
    /// Deletes a namespace from Amazon Redshift Serverless. Before you delete the namespace,
    /// you can create a final snapshot that has all of the data within the namespace.
    /// </summary>
    public partial class DeleteNamespaceRequest : AmazonRedshiftServerlessRequest
    {
        private string _finalSnapshotName;
        private int? _finalSnapshotRetentionPeriod;
        private string _namespaceName;

        /// <summary>
        /// Gets and sets the property FinalSnapshotName. 
        /// <para>
        /// The name of the snapshot to be created before the namespace is deleted.
        /// </para>
        /// </summary>
        public string FinalSnapshotName
        {
            get { return this._finalSnapshotName; }
            set { this._finalSnapshotName = value; }
        }

        // Check to see if FinalSnapshotName property is set
        internal bool IsSetFinalSnapshotName()
        {
            return this._finalSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property FinalSnapshotRetentionPeriod. 
        /// <para>
        /// How long to retain the final snapshot.
        /// </para>
        /// </summary>
        public int? FinalSnapshotRetentionPeriod
        {
            get { return this._finalSnapshotRetentionPeriod; }
            set { this._finalSnapshotRetentionPeriod = value; }
        }

        // Check to see if FinalSnapshotRetentionPeriod property is set
        internal bool IsSetFinalSnapshotRetentionPeriod()
        {
            return this._finalSnapshotRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

    }
}