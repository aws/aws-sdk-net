/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// A structure that contains information about a backed-up resource.
    /// </summary>
    public partial class ProtectedResource
    {
        private DateTime? _lastBackupTime;
        private string _resourceArn;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property LastBackupTime. 
        /// <para>
        /// The date and time a resource was last backed up, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>LastBackupTime</code> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime LastBackupTime
        {
            get { return this._lastBackupTime.GetValueOrDefault(); }
            set { this._lastBackupTime = value; }
        }

        // Check to see if LastBackupTime property is set
        internal bool IsSetLastBackupTime()
        {
            return this._lastBackupTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of AWS resource; for example, an Amazon Elastic Block Store (Amazon EBS)
        /// volume or an Amazon Relational Database Service (Amazon RDS) database.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}