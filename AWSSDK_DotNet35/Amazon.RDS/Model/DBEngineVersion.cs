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
    public class DBEngineVersion
    {
        
        private string engine;
        private string engineVersion;
        private string dBParameterGroupFamily;
        private string dBEngineDescription;
        private string dBEngineVersionDescription;
        private CharacterSet defaultCharacterSet;
        private List<CharacterSet> supportedCharacterSets = new List<CharacterSet>();


        /// <summary>
        /// The name of the database engine.
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// The version number of the database engine.
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// The name of the DB parameter group family for the database engine.
        ///  
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this.dBParameterGroupFamily; }
            set { this.dBParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this.dBParameterGroupFamily != null;
        }

        /// <summary>
        /// The description of the database engine.
        ///  
        /// </summary>
        public string DBEngineDescription
        {
            get { return this.dBEngineDescription; }
            set { this.dBEngineDescription = value; }
        }

        // Check to see if DBEngineDescription property is set
        internal bool IsSetDBEngineDescription()
        {
            return this.dBEngineDescription != null;
        }

        /// <summary>
        /// The description of the database engine version.
        ///  
        /// </summary>
        public string DBEngineVersionDescription
        {
            get { return this.dBEngineVersionDescription; }
            set { this.dBEngineVersionDescription = value; }
        }

        // Check to see if DBEngineVersionDescription property is set
        internal bool IsSetDBEngineVersionDescription()
        {
            return this.dBEngineVersionDescription != null;
        }

        /// <summary>
        /// The default character set for new instances of this engine version, if the <c>CharacterSetName</c> parameter of the CreateDBInstance API is
        /// not specified.
        ///  
        /// </summary>
        public CharacterSet DefaultCharacterSet
        {
            get { return this.defaultCharacterSet; }
            set { this.defaultCharacterSet = value; }
        }

        // Check to see if DefaultCharacterSet property is set
        internal bool IsSetDefaultCharacterSet()
        {
            return this.defaultCharacterSet != null;
        }

        /// <summary>
        /// A list of the character sets supported by this engine for the <c>CharacterSetName</c> parameter of the CreateDBInstance API.
        ///  
        /// </summary>
        public List<CharacterSet> SupportedCharacterSets
        {
            get { return this.supportedCharacterSets; }
            set { this.supportedCharacterSets = value; }
        }

        // Check to see if SupportedCharacterSets property is set
        internal bool IsSetSupportedCharacterSets()
        {
            return this.supportedCharacterSets.Count > 0;
        }
    }
}
