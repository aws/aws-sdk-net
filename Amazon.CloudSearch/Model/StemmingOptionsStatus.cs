/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>The stemming options configured for this search domain and the current status of those options.</para>
    /// </summary>
    public class StemmingOptionsStatus  
    {
        
        private string options;
        private OptionStatus status;

        /// <summary>
        /// Maps terms to their stems, serialized as a JSON document. The document has a single object with one property "stems" whose value is an
        /// object mapping terms to their stems. The maximum size of a stemming document is 500KB. Example: <c>{ "stems": {"people": "person",
        /// "walking": "walk"} }</c>
        ///  
        /// </summary>
        public string Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        /// <summary>
        /// Sets the Options property
        /// </summary>
        /// <param name="options">The value to set for the Options property </param>
        /// <returns>this instance</returns>
        public StemmingOptionsStatus WithOptions(string options)
        {
            this.options = options;
            return this;
        }
            

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;       
        }

        /// <summary>
        /// The status of an option, including when it was last updated and whether it is actively in use for searches.
        ///  
        /// </summary>
        public OptionStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public StemmingOptionsStatus WithStatus(OptionStatus status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;       
        }
    }
}
