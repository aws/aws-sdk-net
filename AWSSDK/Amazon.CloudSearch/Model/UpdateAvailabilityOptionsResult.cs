/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of a <c>UpdateAvailabilityOptions</c> request. Contains the status of the domain's availability options. </para>
    /// </summary>
    public partial class UpdateAvailabilityOptionsResult
    {
        
        private AvailabilityOptionsStatus availabilityOptions;

        /// <summary>
        /// The newly-configured availability options. Indicates whether Multi-AZ is enabled for the domain.
        ///  
        /// </summary>
        public AvailabilityOptionsStatus AvailabilityOptions
        {
            get { return this.availabilityOptions; }
            set { this.availabilityOptions = value; }
        }

        /// <summary>
        /// Sets the AvailabilityOptions property
        /// </summary>
        /// <param name="availabilityOptions">The value to set for the AvailabilityOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAvailabilityOptionsResult WithAvailabilityOptions(AvailabilityOptionsStatus availabilityOptions)
        {
            this.availabilityOptions = availabilityOptions;
            return this;
        }
            

        // Check to see if AvailabilityOptions property is set
        internal bool IsSetAvailabilityOptions()
        {
            return this.availabilityOptions != null;
        }
    }
}
