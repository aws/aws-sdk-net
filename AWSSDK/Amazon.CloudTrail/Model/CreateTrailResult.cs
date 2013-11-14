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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// <para>A JSON-formatted Trail object that represents the settings for the requested trail.</para>
    /// </summary>
    public partial class CreateTrailResult
    {
        
        private Trail trail;

        /// <summary>
        /// Data type that represents the settings for a trail.
        ///  
        /// </summary>
        public Trail Trail
        {
            get { return this.trail; }
            set { this.trail = value; }
        }

        /// <summary>
        /// Sets the Trail property
        /// </summary>
        /// <param name="trail">The value to set for the Trail property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTrailResult WithTrail(Trail trail)
        {
            this.trail = trail;
            return this;
        }
            

        // Check to see if Trail property is set
        internal bool IsSetTrail()
        {
            return this.trail != null;
        }
    }
}
