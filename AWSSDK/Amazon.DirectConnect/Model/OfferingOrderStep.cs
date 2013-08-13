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
    /// <para> A step in the connection order process. </para>
    /// </summary>
    public class OfferingOrderStep  
    {
        
        private string number;
        private string name;
        private string description;
        private string owner;
        private int? sla;

        /// <summary>
        /// Number of an order step. Example: 1
        ///  
        /// </summary>
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        /// <summary>
        /// Sets the Number property
        /// </summary>
        /// <param name="number">The value to set for the Number property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OfferingOrderStep WithNumber(string number)
        {
            this.number = number;
            return this;
        }
            

        // Check to see if Number property is set
        internal bool IsSetNumber()
        {
            return this.number != null;       
        }

        /// <summary>
        /// Name of the order step. Example: Authorize cross connect
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OfferingOrderStep WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;       
        }

        /// <summary>
        /// More detailed description of the order step. Example: "<i>AWS will prepare your connection and send you an email with an LOA-CFA to provide
        /// to the colocation provider</i>"
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OfferingOrderStep WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// Who owns the completion of the order step. Example: AWS
        ///  
        /// </summary>
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        /// <summary>
        /// Sets the Owner property
        /// </summary>
        /// <param name="owner">The value to set for the Owner property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OfferingOrderStep WithOwner(string owner)
        {
            this.owner = owner;
            return this;
        }
            

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;       
        }

        /// <summary>
        /// Time to complete the order step in minutes. Example: 60
        ///  
        /// </summary>
        public int Sla
        {
            get { return this.sla ?? default(int); }
            set { this.sla = value; }
        }

        /// <summary>
        /// Sets the Sla property
        /// </summary>
        /// <param name="sla">The value to set for the Sla property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OfferingOrderStep WithSla(int sla)
        {
            this.sla = sla;
            return this;
        }
            

        // Check to see if Sla property is set
        internal bool IsSetSla()
        {
            return this.sla.HasValue;       
        }
    }
}
