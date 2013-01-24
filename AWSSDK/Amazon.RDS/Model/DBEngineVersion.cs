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

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">The value to set for the Engine property </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithEngine(string engine)
        {
            this.engine = engine;
            return this;
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

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// The name of the DBParameterGroupFamily for the database engine.
        ///  
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this.dBParameterGroupFamily; }
            set { this.dBParameterGroupFamily = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupFamily property
        /// </summary>
        /// <param name="dBParameterGroupFamily">The value to set for the DBParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithDBParameterGroupFamily(string dBParameterGroupFamily)
        {
            this.dBParameterGroupFamily = dBParameterGroupFamily;
            return this;
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

        /// <summary>
        /// Sets the DBEngineDescription property
        /// </summary>
        /// <param name="dBEngineDescription">The value to set for the DBEngineDescription property </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithDBEngineDescription(string dBEngineDescription)
        {
            this.dBEngineDescription = dBEngineDescription;
            return this;
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

        /// <summary>
        /// Sets the DBEngineVersionDescription property
        /// </summary>
        /// <param name="dBEngineVersionDescription">The value to set for the DBEngineVersionDescription property </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithDBEngineVersionDescription(string dBEngineVersionDescription)
        {
            this.dBEngineVersionDescription = dBEngineVersionDescription;
            return this;
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

        /// <summary>
        /// Sets the DefaultCharacterSet property
        /// </summary>
        /// <param name="defaultCharacterSet">The value to set for the DefaultCharacterSet property </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithDefaultCharacterSet(CharacterSet defaultCharacterSet)
        {
            this.defaultCharacterSet = defaultCharacterSet;
            return this;
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
        /// <summary>
        /// Adds elements to the SupportedCharacterSets collection
        /// </summary>
        /// <param name="supportedCharacterSets">The values to add to the SupportedCharacterSets collection </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithSupportedCharacterSets(params CharacterSet[] supportedCharacterSets)
        {
            foreach (CharacterSet element in supportedCharacterSets)
            {
                this.supportedCharacterSets.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the SupportedCharacterSets collection
        /// </summary>
        /// <param name="supportedCharacterSets">The values to add to the SupportedCharacterSets collection </param>
        /// <returns>this instance</returns>
        public DBEngineVersion WithSupportedCharacterSets(IEnumerable<CharacterSet> supportedCharacterSets)
        {
            foreach (CharacterSet element in supportedCharacterSets)
            {
                this.supportedCharacterSets.Add(element);
            }

            return this;
        }

        // Check to see if SupportedCharacterSets property is set
        internal bool IsSetSupportedCharacterSets()
        {
            return this.supportedCharacterSets.Count > 0;
        }
    }
}
