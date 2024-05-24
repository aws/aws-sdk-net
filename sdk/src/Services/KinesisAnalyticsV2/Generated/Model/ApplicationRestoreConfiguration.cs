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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Specifies the method and snapshot to use when restarting an application using previously
    /// saved application state.
    /// </summary>
    public partial class ApplicationRestoreConfiguration
    {
        private ApplicationRestoreType _applicationRestoreType;
        private string _snapshotName;

        /// <summary>
        /// Gets and sets the property ApplicationRestoreType. 
        /// <para>
        /// Specifies how the application should be restored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationRestoreType ApplicationRestoreType
        {
            get { return this._applicationRestoreType; }
            set { this._applicationRestoreType = value; }
        }

        // Check to see if ApplicationRestoreType property is set
        internal bool IsSetApplicationRestoreType()
        {
            return this._applicationRestoreType != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The identifier of an existing snapshot of application state to use to restart an application.
        /// The application uses this value if <c>RESTORE_FROM_CUSTOM_SNAPSHOT</c> is specified
        /// for the <c>ApplicationRestoreType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

    }
}