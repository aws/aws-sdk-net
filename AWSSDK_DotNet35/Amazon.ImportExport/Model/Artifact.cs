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

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// <para> A discrete item that contains the description and URL of an artifact (such as a PDF). </para>
    /// </summary>
    public class Artifact
    {
        
        private string description;
        private string uRL;

        /// <summary>
        /// The associated description for this object.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The URL for a given Artifact.
        ///  
        /// </summary>
        public string URL
        {
            get { return this.uRL; }
            set { this.uRL = value; }
        }

        // Check to see if URL property is set
        internal bool IsSetURL()
        {
            return this.uRL != null;
        }
    }
}
