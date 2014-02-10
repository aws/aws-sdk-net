using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearch.Model
{
   public class DateOptions
    {
        private DateTime defaultValue;
        private bool? searchEnabled;
        private bool? facetEnabled;
        private bool? resultEnabled;
        private bool? sortEnabled;


        /// <summary>
        /// The default value for a literal field. Optional.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DateTime DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// Specifies whether search is enabled for this field. Default: False.
        ///  
        /// </summary>
        public bool SearchEnabled
        {
            get { return this.searchEnabled ?? default(bool); }
            set { this.searchEnabled = value; }
        }

        // Check to see if SearchEnabled property is set
        internal bool IsSetSearchEnabled()
        {
            return this.searchEnabled.HasValue;
        }

        /// <summary>
        /// Specifies whether facets are enabled for this field. Default: False.
        ///  
        /// </summary>
        public bool FacetEnabled
        {
            get { return this.facetEnabled ?? default(bool); }
            set { this.facetEnabled = value; }
        }

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this.facetEnabled.HasValue;
        }

        /// <summary>
        /// Specifies whether values of this field can be returned in search results and used for ranking. Default: False.
        ///  
        /// </summary>
        public bool ResultEnabled
        {
            get { return this.resultEnabled ?? default(bool); }
            set { this.resultEnabled = value; }
        }

        // Check to see if ResultEnabled property is set
        internal bool IsSetResultEnabled()
        {
            return this.resultEnabled.HasValue;
        }

        public bool SortEnabled
        {
            get { return this.sortEnabled ?? default(bool); }
            set { this.sortEnabled = value; }
        }

        internal bool IsSortEnabled()
        {
            return this.sortEnabled.HasValue;
        }
    }
}
