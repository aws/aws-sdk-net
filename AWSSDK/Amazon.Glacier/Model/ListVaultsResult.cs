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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public class ListVaultsResult  
    {
        
        private List<DescribeVaultOutput> vaultList = new List<DescribeVaultOutput>();
        private string marker;

        /// <summary>
        /// List of vaults.
        ///  
        /// </summary>
        public List<DescribeVaultOutput> VaultList
        {
            get { return this.vaultList; }
            set { this.vaultList = value; }
        }
        /// <summary>
        /// Adds elements to the VaultList collection
        /// </summary>
        /// <param name="vaultList">The values to add to the VaultList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVaultsResult WithVaultList(params DescribeVaultOutput[] vaultList)
        {
            foreach (DescribeVaultOutput element in vaultList)
            {
                this.vaultList.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VaultList collection
        /// </summary>
        /// <param name="vaultList">The values to add to the VaultList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVaultsResult WithVaultList(IEnumerable<DescribeVaultOutput> vaultList)
        {
            foreach (DescribeVaultOutput element in vaultList)
            {
                this.vaultList.Add(element);
            }

            return this;
        }

        // Check to see if VaultList property is set
        internal bool IsSetVaultList()
        {
            return this.vaultList.Count > 0;       
        }

        /// <summary>
        /// The vault ARN at which to continue pagination of the results. You use the marker in another List Vaults request to obtain more vaults in the
        /// list.
        ///  
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVaultsResult WithMarker(string marker)
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
