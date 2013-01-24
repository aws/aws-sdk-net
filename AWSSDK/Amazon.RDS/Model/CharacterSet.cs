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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> This data type is used as a response element in the action DescribeDBEngineVersions. </para>
    /// </summary>
    public class CharacterSet
    {
        
        private string characterSetName;
        private string characterSetDescription;

        /// <summary>
        /// The name of the character set.
        ///  
        /// </summary>
        public string CharacterSetName
        {
            get { return this.characterSetName; }
            set { this.characterSetName = value; }
        }

        /// <summary>
        /// Sets the CharacterSetName property
        /// </summary>
        /// <param name="characterSetName">The value to set for the CharacterSetName property </param>
        /// <returns>this instance</returns>
        public CharacterSet WithCharacterSetName(string characterSetName)
        {
            this.characterSetName = characterSetName;
            return this;
        }
            

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this.characterSetName != null;
        }

        /// <summary>
        /// The description of the character set.
        ///  
        /// </summary>
        public string CharacterSetDescription
        {
            get { return this.characterSetDescription; }
            set { this.characterSetDescription = value; }
        }

        /// <summary>
        /// Sets the CharacterSetDescription property
        /// </summary>
        /// <param name="characterSetDescription">The value to set for the CharacterSetDescription property </param>
        /// <returns>this instance</returns>
        public CharacterSet WithCharacterSetDescription(string characterSetDescription)
        {
            this.characterSetDescription = characterSetDescription;
            return this;
        }
            

        // Check to see if CharacterSetDescription property is set
        internal bool IsSetCharacterSetDescription()
        {
            return this.characterSetDescription != null;
        }
    }
}
