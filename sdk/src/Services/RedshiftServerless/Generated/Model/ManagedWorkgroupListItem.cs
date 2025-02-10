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
    /// A collection of Amazon Redshift compute resources managed by AWS Glue.
    /// </summary>
    public partial class ManagedWorkgroupListItem
    {
        private DateTime? _creationDate;
        private string _managedWorkgroupId;
        private string _managedWorkgroupName;
        private string _sourceArn;
        private ManagedWorkgroupStatus _status;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the managed workgroup.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedWorkgroupId. 
        /// <para>
        /// The unique identifier of the managed workgroup.
        /// </para>
        /// </summary>
        public string ManagedWorkgroupId
        {
            get { return this._managedWorkgroupId; }
            set { this._managedWorkgroupId = value; }
        }

        // Check to see if ManagedWorkgroupId property is set
        internal bool IsSetManagedWorkgroupId()
        {
            return this._managedWorkgroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedWorkgroupName. 
        /// <para>
        /// The name of the managed workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string ManagedWorkgroupName
        {
            get { return this._managedWorkgroupName; }
            set { this._managedWorkgroupName = value; }
        }

        // Check to see if ManagedWorkgroupName property is set
        internal bool IsSetManagedWorkgroupName()
        {
            return this._managedWorkgroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the managed workgroup in the AWS Glue Data Catalog.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the managed workgroup.
        /// </para>
        /// </summary>
        public ManagedWorkgroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}