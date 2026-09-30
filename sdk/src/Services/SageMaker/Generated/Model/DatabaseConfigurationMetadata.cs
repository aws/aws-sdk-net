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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata information about a change to the external Slurm accounting database of a
    /// HyperPod cluster.
    /// </summary>
    public partial class DatabaseConfigurationMetadata
    {
        private string _advisory;
        private string _failureMessage;
        private DatabaseConfigurationRollbackStatus _rollbackStatus;

        /// <summary>
        /// Gets and sets the property Advisory. 
        /// <para>
        /// Additional information about a change that succeeded, such as an action to take on
        /// the cluster.
        /// </para>
        /// </summary>
        public string Advisory
        {
            get { return this._advisory; }
            set { this._advisory = value; }
        }

        // Check to see if Advisory property is set
        internal bool IsSetAdvisory()
        {
            return this._advisory != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message describing why the accounting database change failed, and how to
        /// resolve it.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackStatus. 
        /// <para>
        /// Whether HyperPod restored the previous accounting database configuration after the
        /// change failed. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NotApplicable</c>: The change failed before HyperPod modified the cluster, for
        /// example because the database could not be reached or rejected the credentials, so
        /// there was nothing to restore.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Reverted</c>: The change failed after it was applied, and HyperPod restored the
        /// previous configuration. The cluster continues to use the previous accounting database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RevertFailed</c>: The change failed and HyperPod could not restore the previous
        /// configuration, so Slurm accounting on the cluster might not be working.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This field is omitted when the change succeeds.
        /// </para>
        /// </summary>
        public DatabaseConfigurationRollbackStatus RollbackStatus
        {
            get { return this._rollbackStatus; }
            set { this._rollbackStatus = value; }
        }

        // Check to see if RollbackStatus property is set
        internal bool IsSetRollbackStatus()
        {
            return this._rollbackStatus != null;
        }

    }
}