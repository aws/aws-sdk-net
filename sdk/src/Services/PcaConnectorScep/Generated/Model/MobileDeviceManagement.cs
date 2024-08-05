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
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorScep.Model
{
    /// <summary>
    /// If you don't supply a value, by default Connector for SCEP creates a connector for
    /// general-purpose use. A general-purpose connector is designed to work with clients
    /// or endpoints that support the SCEP protocol, except Connector for SCEP for Microsoft
    /// Intune. For information about considerations and limitations with using Connector
    /// for SCEP, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlc4scep-considerations-limitations.html">Considerations
    /// and Limitations</a>.
    /// 
    ///  
    /// <para>
    /// If you provide an <c>IntuneConfiguration</c>, Connector for SCEP creates a connector
    /// for use with Microsoft Intune, and you manage the challenge passwords using Microsoft
    /// Intune. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-intune.html">Using
    /// Connector for SCEP for Microsoft Intune</a>.
    /// </para>
    /// </summary>
    public partial class MobileDeviceManagement
    {
        private IntuneConfiguration _intune;

        /// <summary>
        /// Gets and sets the property Intune. 
        /// <para>
        /// Configuration settings for use with Microsoft Intune. For information about using
        /// Connector for SCEP for Microsoft Intune, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-intune.html">Using
        /// Connector for SCEP for Microsoft Intune</a>.
        /// </para>
        /// </summary>
        public IntuneConfiguration Intune
        {
            get { return this._intune; }
            set { this._intune = value; }
        }

        // Check to see if Intune property is set
        internal bool IsSetIntune()
        {
            return this._intune != null;
        }

    }
}