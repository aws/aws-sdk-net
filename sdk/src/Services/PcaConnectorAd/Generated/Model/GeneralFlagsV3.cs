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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// General flags for v3 template schema that defines if the template is for a machine
    /// or a user and if the template can be issued using autoenrollment.
    /// </summary>
    public partial class GeneralFlagsV3
    {
        private bool? _autoEnrollment;
        private bool? _machineType;

        /// <summary>
        /// Gets and sets the property AutoEnrollment. 
        /// <para>
        /// Allows certificate issuance using autoenrollment. Set to TRUE to allow autoenrollment.
        /// </para>
        /// </summary>
        public bool? AutoEnrollment
        {
            get { return this._autoEnrollment; }
            set { this._autoEnrollment = value; }
        }

        // Check to see if AutoEnrollment property is set
        internal bool IsSetAutoEnrollment()
        {
            return this._autoEnrollment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MachineType. 
        /// <para>
        /// Defines if the template is for machines or users. Set to TRUE if the template is for
        /// machines. Set to FALSE if the template is for users
        /// </para>
        /// </summary>
        public bool? MachineType
        {
            get { return this._machineType; }
            set { this._machineType = value; }
        }

        // Check to see if MachineType property is set
        internal bool IsSetMachineType()
        {
            return this._machineType.HasValue; 
        }

    }
}