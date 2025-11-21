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
    /// Container for the parameters to the DisassociateSoftwareFromImageBuilder operation.
    /// Removes license included application(s) association(s) from an image builder instance.
    /// </summary>
    public partial class DisassociateSoftwareFromImageBuilderRequest : AmazonAppStreamRequest
    {
        private string _imageBuilderName;
        private List<string> _softwareNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ImageBuilderName. 
        /// <para>
        /// The name of the target image builder instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageBuilderName
        {
            get { return this._imageBuilderName; }
            set { this._imageBuilderName = value; }
        }

        // Check to see if ImageBuilderName property is set
        internal bool IsSetImageBuilderName()
        {
            return this._imageBuilderName != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareNames. 
        /// <para>
        /// The list of license included applications to disassociate from the image builder.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SoftwareNames
        {
            get { return this._softwareNames; }
            set { this._softwareNames = value; }
        }

        // Check to see if SoftwareNames property is set
        internal bool IsSetSoftwareNames()
        {
            return this._softwareNames != null && (this._softwareNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}