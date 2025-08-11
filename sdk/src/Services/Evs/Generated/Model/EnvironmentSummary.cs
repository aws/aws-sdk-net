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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// A list of environments with summarized environment details.
    /// </summary>
    public partial class EnvironmentSummary
    {
        private DateTime? _createdAt;
        private string _environmentArn;
        private string _environmentId;
        private string _environmentName;
        private EnvironmentState _environmentState;
        private CheckResult _environmentStatus;
        private DateTime? _modifiedAt;
        private VcfVersion _vcfVersion;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The date and time that the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EnvironmentArn
        {
            get { return this._environmentArn; }
            set { this._environmentArn = value; }
        }

        // Check to see if EnvironmentArn property is set
        internal bool IsSetEnvironmentArn()
        {
            return this._environmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///  The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentState. 
        /// <para>
        /// The state of an environment.
        /// </para>
        /// </summary>
        public EnvironmentState EnvironmentState
        {
            get { return this._environmentState; }
            set { this._environmentState = value; }
        }

        // Check to see if EnvironmentState property is set
        internal bool IsSetEnvironmentState()
        {
            return this._environmentState != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentStatus. 
        /// <para>
        /// Reports impaired functionality that stems from issues internal to the environment,
        /// such as impaired reachability.
        /// </para>
        /// </summary>
        public CheckResult EnvironmentStatus
        {
            get { return this._environmentStatus; }
            set { this._environmentStatus = value; }
        }

        // Check to see if EnvironmentStatus property is set
        internal bool IsSetEnvironmentStatus()
        {
            return this._environmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the environment was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VcfVersion. 
        /// <para>
        /// The VCF version of the environment.
        /// </para>
        /// </summary>
        public VcfVersion VcfVersion
        {
            get { return this._vcfVersion; }
            set { this._vcfVersion = value; }
        }

        // Check to see if VcfVersion property is set
        internal bool IsSetVcfVersion()
        {
            return this._vcfVersion != null;
        }

    }
}