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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The association between a license-included application and a resource.
    /// </summary>
    public partial class SoftwareAssociations
    {
        private List<ErrorDetails> _deploymentError = AWSConfigs.InitializeCollections ? new List<ErrorDetails>() : null;
        private string _softwareName;
        private SoftwareDeploymentStatus _status;

        /// <summary>
        /// Gets and sets the property DeploymentError. 
        /// <para>
        /// The error details for failed deployments of the license-included application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetails> DeploymentError
        {
            get { return this._deploymentError; }
            set { this._deploymentError = value; }
        }

        // Check to see if DeploymentError property is set
        internal bool IsSetDeploymentError()
        {
            return this._deploymentError != null && (this._deploymentError.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SoftwareName. 
        /// <para>
        /// The name of the license-included application.
        /// </para>
        ///  
        /// <para>
        /// Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Professional_Plus_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Professional_Plus_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Professional_Plus_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Professional_Plus_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Standard_64Bit
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SoftwareName
        {
            get { return this._softwareName; }
            set { this._softwareName = value; }
        }

        // Check to see if SoftwareName property is set
        internal bool IsSetSoftwareName()
        {
            return this._softwareName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status of the license-included application.
        /// </para>
        /// </summary>
        public SoftwareDeploymentStatus Status
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