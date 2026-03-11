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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// Additional settings that directly map to Slurm settings.
    /// 
    ///  <important> 
    /// <para>
    /// PCS supports a subset of Slurm settings. For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/slurm-custom-settings.html">Configuring
    /// custom Slurm settings in PCS</a> in the <i>PCS User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SlurmCustomSetting
    {
        private string _parameterName;
        private string _parameterValue;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// PCS supports custom Slurm settings for clusters, compute node groups, and queues.
        /// For more information, see <a href="https://docs.aws.amazon.com/pcs/latest/userguide/slurm-custom-settings.html">Configuring
        /// custom Slurm settings in PCS</a> in the <i>PCS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The values for the configured Slurm settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

    }
}