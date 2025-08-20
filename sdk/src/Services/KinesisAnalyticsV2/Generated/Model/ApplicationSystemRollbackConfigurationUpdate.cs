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
    /// Describes the system rollback configuration for a Managed Service for Apache Flink
    /// application.
    /// </summary>
    public partial class ApplicationSystemRollbackConfigurationUpdate
    {
        private bool? _rollbackEnabledUpdate;

        /// <summary>
        /// Gets and sets the property RollbackEnabledUpdate. 
        /// <para>
        /// Describes whether system rollbacks are enabled for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? RollbackEnabledUpdate
        {
            get { return this._rollbackEnabledUpdate; }
            set { this._rollbackEnabledUpdate = value; }
        }

        // Check to see if RollbackEnabledUpdate property is set
        internal bool IsSetRollbackEnabledUpdate()
        {
            return this._rollbackEnabledUpdate.HasValue; 
        }

    }
}