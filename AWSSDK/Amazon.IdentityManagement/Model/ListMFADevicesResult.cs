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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the ListMFADevices action.</para>
    /// </summary>
    public class ListMFADevicesResult  
    {
        
        private List<MFADevice> mFADevices = new List<MFADevice>();
        private bool? isTruncated;
        private string marker;

        /// <summary>
        /// A list of MFA devices.
        ///  
        /// </summary>
        public List<MFADevice> MFADevices
        {
            get { return this.mFADevices; }
            set { this.mFADevices = value; }
        }
        /// <summary>
        /// Adds elements to the MFADevices collection
        /// </summary>
        /// <param name="mFADevices">The values to add to the MFADevices collection </param>
        /// <returns>this instance</returns>
        public ListMFADevicesResult WithMFADevices(params MFADevice[] mFADevices)
        {
            foreach (MFADevice element in mFADevices)
            {
                this.mFADevices.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the MFADevices collection
        /// </summary>
        /// <param name="mFADevices">The values to add to the MFADevices collection </param>
        /// <returns>this instance</returns>
        public ListMFADevicesResult WithMFADevices(IEnumerable<MFADevice> mFADevices)
        {
            foreach (MFADevice element in mFADevices)
            {
                this.mFADevices.Add(element);
            }

            return this;
        }

        // Check to see if MFADevices property is set
        internal bool IsSetMFADevices()
        {
            return this.mFADevices.Count > 0;       
        }

        /// <summary>
        /// A flag that indicates whether there are more MFA devices to list. If your results were truncated, you can make a subsequent pagination
        /// request using the <c>Marker</c> request parameter to retrieve more MFA devices in the list.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// Sets the IsTruncated property
        /// </summary>
        /// <param name="isTruncated">The value to set for the IsTruncated property </param>
        /// <returns>this instance</returns>
        public ListMFADevicesResult WithIsTruncated(bool isTruncated)
        {
            this.isTruncated = isTruncated;
            return this;
        }
            

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;       
        }

        /// <summary>
        /// If <c>IsTruncated</c> is <c>true</c>, this element is present and contains the value to use for the <c>Marker</c> parameter in a subsequent
        /// pagination request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public ListMFADevicesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }
    }
}
