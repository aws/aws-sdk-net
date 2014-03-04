/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>A Direct Connect location where connections and interconnects can be requested.</para>
    /// </summary>
    public class Location
    {
        
        private string locationCode;
        private string locationName;

        /// <summary>
        /// The code used to indicate the Direct Connect location.
        ///  
        /// </summary>
        public string LocationCode
        {
            get { return this.locationCode; }
            set { this.locationCode = value; }
        }

        /// <summary>
        /// Sets the LocationCode property
        /// </summary>
        /// <param name="locationCode">The value to set for the LocationCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Location WithLocationCode(string locationCode)
        {
            this.locationCode = locationCode;
            return this;
        }
            

        // Check to see if LocationCode property is set
        internal bool IsSetLocationCode()
        {
            return this.locationCode != null;
        }

        /// <summary>
        /// The name of the Direct Connect location. The name includes the colocation partner name and the physical site of the lit building
        ///  
        /// </summary>
        public string LocationName
        {
            get { return this.locationName; }
            set { this.locationName = value; }
        }

        /// <summary>
        /// Sets the LocationName property
        /// </summary>
        /// <param name="locationName">The value to set for the LocationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Location WithLocationName(string locationName)
        {
            this.locationName = locationName;
            return this;
        }
            

        // Check to see if LocationName property is set
        internal bool IsSetLocationName()
        {
            return this.locationName != null;
        }
    }
}
