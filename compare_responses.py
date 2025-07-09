#!/usr/bin/env python3
"""
S3 Presigned POST Response Comparison Script

Compares JavaScript and .NET SDK response JSON files to validate consistent behavior.
Handles timestamp-dependent fields by validating structure rather than exact values.
"""

import json
import glob
import sys
from typing import Dict, List, Any, Tuple, Optional
from pathlib import Path

class ResponseComparison:
    """Compares S3 presigned POST responses between JavaScript and .NET SDKs"""
    
    # Fields that should have identical values
    EXACT_MATCH_FIELDS = {
        'testname',  # Normalized case
        'key',
        'acl', 
        'x-amz-algorithm'
    }
    
    # Fields that should exist but values will differ due to timestamps
    STRUCTURE_ONLY_FIELDS = {
        'url',
        'policy', 
        'x-amz-date',
        'x-amz-signature',
        'x-amz-credential',
        'expiration',  # In decoded policy
        'content-type'  # Both SDKs handle Content-Type identically now
    }
    
    def __init__(self):
        self.results = []
        
    def normalize_key(self, key: str) -> str:
        """Convert PascalCase/camelCase to lowercase for comparison"""
        return key.lower()
        
    def normalize_response(self, response: Dict[str, Any]) -> Dict[str, Any]:
        """Normalize response structure for comparison"""
        normalized = {}
        
        for key, value in response.items():
            norm_key = self.normalize_key(key)
            
            if isinstance(value, dict):
                # Recursively normalize nested dictionaries
                normalized[norm_key] = self.normalize_response(value)
            elif isinstance(value, list):
                # Handle lists (like policy conditions)
                normalized[norm_key] = self.normalize_list(value)
            else:
                normalized[norm_key] = value
                
        return normalized
        
    def normalize_list(self, items: List[Any]) -> List[Any]:
        """Normalize list items"""
        normalized = []
        for item in items:
            if isinstance(item, dict):
                normalized.append(self.normalize_response(item))
            elif isinstance(item, list):
                normalized.append(self.normalize_list(item))
            else:
                normalized.append(item)
        return normalized
        
    def compare_policy_conditions(self, js_conditions: List[Any], dotnet_conditions: List[Any]) -> Dict[str, Any]:
        """Compare policy conditions, handling order differences"""
        result = {
            'match': True,
            'issues': [],
            'js_count': len(js_conditions),
            'dotnet_count': len(dotnet_conditions),
            'js_only_conditions': [],
            'dotnet_only_conditions': [],
            'different_conditions': []
        }
        
        # Normalize and sort conditions for comparison
        js_normalized = self.normalize_conditions_for_comparison(js_conditions)
        dotnet_normalized = self.normalize_conditions_for_comparison(dotnet_conditions)
        
        if len(js_conditions) != len(dotnet_conditions):
            result['match'] = False
            result['issues'].append(f"Condition count mismatch: JavaScript={len(js_conditions)}, .NET={len(dotnet_conditions)}")
        
        # Find matches for each condition type
        condition_types = ['exact_match', 'starts_with', 'content_length_range', 'aws_fields']
        
        for condition_type in condition_types:
            js_conds = js_normalized.get(condition_type, [])
            net_conds = dotnet_normalized.get(condition_type, [])
            
            if condition_type == 'aws_fields':
                # AWS fields can have timestamp differences, just check structure
                self.compare_aws_fields(js_conds, net_conds, result)
            else:
                # Find differences by comparing as strings
                js_conds_set = set(str(c) for c in js_conds)
                net_conds_set = set(str(c) for c in net_conds)
                
                # Items in JavaScript but not in .NET
                for js_cond_str in js_conds_set - net_conds_set:
                    js_cond = next(c for c in js_conds if str(c) == js_cond_str)
                    result['js_only_conditions'].append({
                        'type': condition_type,
                        'condition': js_cond
                    })
                
                # Items in .NET but not in JavaScript
                for net_cond_str in net_conds_set - js_conds_set:
                    net_cond = next(c for c in net_conds if str(c) == net_cond_str)
                    result['dotnet_only_conditions'].append({
                        'type': condition_type,
                        'condition': net_cond
                    })
                
                # If the sets don't match, mark as not matching
                if js_conds_set != net_conds_set:
                    result['match'] = False
                    
                    # Add detailed explanation about what differs
                    if result['js_only_conditions'] or result['dotnet_only_conditions']:
                        result['issues'].append(f"{condition_type} conditions differ between SDKs")
        
        return result
        
    def normalize_conditions_for_comparison(self, conditions: List[Any]) -> Dict[str, List[Any]]:
        """Group and normalize conditions by type"""
        grouped = {
            'exact_match': [],
            'starts_with': [],
            'content_length_range': [],
            'aws_fields': []
        }
        
        for condition in conditions:
            if isinstance(condition, dict):
                # Exact match conditions
                for key, value in condition.items():
                    norm_key = self.normalize_key(key)
                    if norm_key in ['x-amz-credential', 'x-amz-algorithm', 'x-amz-date']:
                        grouped['aws_fields'].append({norm_key: value})
                    else:
                        grouped['exact_match'].append({norm_key: value})
            elif isinstance(condition, list) and len(condition) >= 2:
                # Array conditions
                if condition[0] == "starts-with":
                    # Normalize the field reference
                    field_ref = condition[1].lower() if isinstance(condition[1], str) else condition[1]
                    # Remove leading $ if present
                    if isinstance(field_ref, str) and field_ref.startswith('$'):
                        field_ref = field_ref[1:]
                    grouped['starts_with'].append([condition[0], field_ref, condition[2]])
                elif condition[0] == "content-length-range":
                    grouped['content_length_range'].append(condition)
        
        # Sort for consistent comparison
        for key in grouped:
            grouped[key].sort(key=str)
            
        return grouped
        
    def compare_aws_fields(self, js_fields: List[Dict], dotnet_fields: List[Dict], result: Dict[str, Any]):
        """Compare AWS-specific fields (structure only for timestamp-dependent ones)"""
        js_keys = set()
        net_keys = set()
        
        for field in js_fields:
            js_keys.update(field.keys())
        for field in dotnet_fields:
            net_keys.update(field.keys())
            
        if js_keys != net_keys:
            result['match'] = False
            result['issues'].append(f"AWS field keys differ: JavaScript={js_keys}, .NET={net_keys}")
        
    def compare_responses(self, js_file: str, dotnet_file: str) -> Dict[str, Any]:
        """Compare a pair of response files"""
        try:
            with open(js_file, 'r') as f:
                js_data = json.load(f)
            with open(dotnet_file, 'r') as f:
                dotnet_data = json.load(f)
        except Exception as e:
            return {
                'files': {'javascript': js_file, 'dotnet': dotnet_file},
                'error': f"Failed to load files: {e}",
                'success': False
            }
        
        # Normalize responses
        js_norm = self.normalize_response(js_data)
        dotnet_norm = self.normalize_response(dotnet_data)
        
        result = {
            'files': {'javascript': js_file, 'dotnet': dotnet_file},
            'success': True,
            'overall_match': True,
            'field_comparisons': {},
            'policy_comparison': {},
            'issues': []
        }
        
        # Get all unique field keys from both responses
        all_fields = set(js_norm.keys()) | set(dotnet_norm.keys())
        
        for field in all_fields:
            field_result = self.compare_field(field, js_norm.get(field), dotnet_norm.get(field))
            result['field_comparisons'][field] = field_result
            
            if not field_result['match']:
                result['overall_match'] = False
                result['issues'].extend(field_result.get('issues', []))
        
        # Special handling for decoded policy comparison
        if 'decodedpolicy' in js_norm and 'decodedpolicy' in dotnet_norm:
            policy_result = self.compare_decoded_policies(
                js_norm['decodedpolicy'], 
                dotnet_norm['decodedpolicy']
            )
            result['policy_comparison'] = policy_result
            
            if not policy_result['match']:
                result['overall_match'] = False
                result['issues'].extend(policy_result.get('issues', []))
        
        return result
        
    def compare_field(self, field_name: str, js_value: Any, dotnet_value: Any) -> Dict[str, Any]:
        """Compare a specific field between responses"""
        norm_field = self.normalize_key(field_name)
        
        result = {
            'field': field_name,
            'match': True,
            'comparison_type': 'exact',
            'issues': []
        }
        
        # Check if both responses have this field
        if js_value is None and dotnet_value is None:
            result['comparison_type'] = 'both_missing'
            return result
        elif js_value is None:
            result['match'] = False
            result['issues'].append(f"Field missing in JavaScript response")
            return result
        elif dotnet_value is None:
            result['match'] = False
            result['issues'].append(f"Field missing in .NET response")
            return result
        
        # Determine comparison type
        if norm_field in self.EXACT_MATCH_FIELDS:
            result['comparison_type'] = 'exact'
            if js_value != dotnet_value:
                result['match'] = False
                result['issues'].append(f"Value mismatch: JavaScript='{js_value}', .NET='{dotnet_value}'")
        elif norm_field in self.STRUCTURE_ONLY_FIELDS:
            result['comparison_type'] = 'structure_only'
            # For structure-only fields, we just verify both have values
            if not js_value or not dotnet_value:
                result['match'] = False
                result['issues'].append(f"Empty value detected")
        else:
            # Default to type and basic structure comparison
            result['comparison_type'] = 'type_structure'
            if type(js_value) != type(dotnet_value):
                result['match'] = False
                result['issues'].append(f"Type mismatch: JavaScript={type(js_value)}, .NET={type(dotnet_value)}")
        
        return result
        
    def compare_decoded_policies(self, js_policy: Dict[str, Any], dotnet_policy: Dict[str, Any]) -> Dict[str, Any]:
        """Compare decoded policy documents"""
        result = {
            'match': True,
            'issues': []
        }
        
        # Check expiration exists but don't compare exact value (timestamp-dependent)
        if 'expiration' not in js_policy:
            result['match'] = False
            result['issues'].append("Expiration missing in JavaScript policy")
        if 'expiration' not in dotnet_policy:
            result['match'] = False
            result['issues'].append("Expiration missing in .NET policy")
        
        # Compare conditions
        if 'conditions' in js_policy and 'conditions' in dotnet_policy:
            conditions_result = self.compare_policy_conditions(
                js_policy['conditions'], 
                dotnet_policy['conditions']
            )
            
            result.update(conditions_result)
        else:
            result['match'] = False
            if 'conditions' not in js_policy:
                result['issues'].append("Conditions missing in JavaScript policy")
            if 'conditions' not in dotnet_policy:
                result['issues'].append("Conditions missing in .NET policy")
        
        return result
        
    def find_response_pairs(self) -> List[Tuple[str, str]]:
        """Find matching JavaScript and .NET response file pairs across directories"""
        # Look in specific directories for response files
        js_patterns = [
            "js_*_response.json",                            # Current directory
            "js-s3-presigned-post-test/js_*_response.json"   # JavaScript test directory
        ]
        
        dotnet_patterns = [
            "dotnet_*_response.json",                        # Current directory
            "S3PostAotDemo/dotnet_*_response.json"           # .NET test directory
        ]
        
        # Find all JS files first
        js_files = []
        for pattern in js_patterns:
            js_files.extend(glob.glob(pattern))
        
        # Group all found .NET files by test name for faster lookup
        dotnet_files_map = {}
        for pattern in dotnet_patterns:
            for file_path in glob.glob(pattern):
                # Extract the test name from the filename
                file_name = Path(file_path).name
                test_name = file_name.replace('dotnet_', '').replace('_response.json', '')
                dotnet_files_map[test_name] = file_path
        
        # Match JavaScript files with corresponding .NET files
        pairs = []
        for js_file in js_files:
            # Extract test name from JavaScript file
            js_file_name = Path(js_file).name
            test_name = js_file_name.replace('js_', '').replace('_response.json', '')
            
            # Look for corresponding .NET file in our map
            if test_name in dotnet_files_map:
                pairs.append((js_file, dotnet_files_map[test_name]))
                print(f"Found match: {js_file} ↔ {dotnet_files_map[test_name]}")
        
        return pairs
        
    def generate_report(self, results: List[Dict[str, Any]]) -> str:
        """Generate a human-readable comparison report"""
        report = []
        report.append("=" * 80)
        report.append("S3 PRESIGNED POST SDK COMPARISON REPORT")
        report.append("=" * 80)
        report.append("")
        
        total_comparisons = len(results)
        successful_comparisons = len([r for r in results if r.get('success', False)])
        matching_comparisons = len([r for r in results if r.get('overall_match', False)])
        
        report.append(f"SUMMARY:")
        report.append(f"  Total Comparisons: {total_comparisons}")
        report.append(f"  Successful Loads: {successful_comparisons}")
        report.append(f"  Perfect Matches: {matching_comparisons}")
        report.append(f"  Match Rate: {matching_comparisons/successful_comparisons*100:.1f}%" if successful_comparisons > 0 else "  Match Rate: N/A")
        report.append("")
        
        for i, result in enumerate(results, 1):
            report.append(f"COMPARISON {i}: {Path(result['files']['javascript']).stem}")
            report.append("-" * 60)
            
            if not result.get('success', False):
                report.append(f"❌ ERROR: {result.get('error', 'Unknown error')}")
                report.append("")
                continue
            
            if result.get('overall_match', False):
                report.append("✅ OVERALL: MATCH")
            else:
                report.append("❌ OVERALL: DIFFERENCES FOUND")
            
            report.append(f"   JavaScript: {result['files']['javascript']}")
            report.append(f"   .NET:      {result['files']['dotnet']}")
            report.append("")
            
            # Field-by-field comparison
            if result.get('field_comparisons'):
                report.append("FIELD COMPARISON:")
                for field, field_result in result['field_comparisons'].items():
                    status = "✅" if field_result['match'] else "❌"
                    comp_type = field_result['comparison_type']
                    report.append(f"  {status} {field:<20} ({comp_type})")
                    
                    for issue in field_result.get('issues', []):
                        report.append(f"      └─ {issue}")
                report.append("")
            
            # Policy comparison details
            if result.get('policy_comparison'):
                policy_result = result['policy_comparison']
                status = "✅" if policy_result.get('match', False) else "❌"
                report.append(f"POLICY COMPARISON: {status}")
                
                if 'js_count' in policy_result and 'dotnet_count' in policy_result:
                    report.append(f"  Condition Count: JavaScript={policy_result['js_count']}, .NET={policy_result['dotnet_count']}")
                
                # Show conditions only in JavaScript
                if 'js_only_conditions' in policy_result and policy_result['js_only_conditions']:
                    report.append(f"  Conditions only in JavaScript:")
                    for cond in policy_result['js_only_conditions']:
                        report.append(f"    └─ [{cond['type']}] {cond['condition']}")
                
                # Show conditions only in .NET
                if 'dotnet_only_conditions' in policy_result and policy_result['dotnet_only_conditions']:
                    report.append(f"  Conditions only in .NET:")
                    for cond in policy_result['dotnet_only_conditions']:
                        report.append(f"    └─ [{cond['type']}] {cond['condition']}")
                
                # Show issues
                for issue in policy_result.get('issues', []):
                    report.append(f"  └─ {issue}")
                report.append("")
            
            # Overall issues
            if result.get('issues'):
                report.append("ISSUES:")
                for issue in result['issues']:
                    report.append(f"  • {issue}")
                report.append("")
        
        return "\n".join(report)

def main():
    """Main entry point"""
    print("S3 Presigned POST Response Comparison Tool")
    print("=" * 50)
    
    comparator = ResponseComparison()
    
    # Find all response file pairs
    pairs = comparator.find_response_pairs()
    
    if not pairs:
        print("❌ No matching response file pairs found!")
        print("Expected files like: js_*_response.json and dotnet_*_response.json")
        return 1
    
    print(f"Found {len(pairs)} response file pairs to compare:")
    for js_file, net_file in pairs:
        print(f"  • {Path(js_file).name} ↔ {Path(net_file).name}")
    print()
    
    # Compare each pair
    results = []
    for js_file, net_file in pairs:
        print(f"Comparing {Path(js_file).stem}...")
        result = comparator.compare_responses(js_file, net_file)
        results.append(result)
    
    # Generate and display report
    report = comparator.generate_report(results)
    print(report)
    
    # Save report to file
    with open('comparison_report.txt', 'w', encoding='utf-8') as f:
        f.write(report)
    print(f"📄 Full report saved to: comparison_report.txt")
    
    # Return appropriate exit code
    successful_matches = len([r for r in results if r.get('overall_match', False)])
    if successful_matches == len(results):
        print(f"\n🎉 All {len(results)} comparisons matched perfectly!")
        return 0
    else:
        print(f"\n⚠️  {len(results) - successful_matches} of {len(results)} comparisons had differences.")
        return 1

if __name__ == "__main__":
    sys.exit(main())
