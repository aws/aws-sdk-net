# DevConfig Manager Action

A JavaScript-based GitHub Action that analyzes AWS SDK .NET pull requests and suggests DevConfig files. This action replaces the previous shell-script-based workflows with secure, maintainable JavaScript code.

## Usage

```yaml
- uses: ./.github/actions/devconfig-manager
  with:
    pr-title: ${{ github.event.pull_request.title }}
    pr-number: ${{ github.event.pull_request.number }}
    branch-name: ${{ github.head_ref || github.ref_name }}
    github-token: ${{ secrets.GITHUB_TOKEN }}
```

## What It Does

1. **Analyzes Changes**: Uses git diff to detect core and service changes
2. **Checks Existing DevConfig**: Looks for existing DevConfig files in the PR
3. **Generates Suggestions**: Creates a DevConfig JSON based on detected changes
4. **Posts Comment**: Adds a helpful comment with copy-paste instructions

## Architecture

### Core Modules

- **`index.js`**: Main entry point for validation
- **`lib/devconfig-generator.js`**: Generates DevConfig JSON from changes
- **`lib/file-analyzer.js`**: Analyzes git changes using simple-git
- **`lib/github-api.js`**: Posts DevConfig preview comments
- **`lib/file-operations.js`**: Checks for existing DevConfig files


## Development

### Setup
```bash
cd .github/actions/devconfig-manager
npm install
```

### Making Changes
1. Edit source files in `lib/` or `index.js`
2. Build the distribution: `npm run build`
3. Commit both source and built files (`lib/`, `dist/`, and any changes to `index.js`)

### Build
```bash
npm run build
```
This creates a bundled `dist/index.js` with all dependencies included.

### Test
```bash
npm test
```

### Lint
```bash
npm run lint
```

**Important**: Always run `npm run build` and commit the updated `dist/` folder after making code changes. The workflow runs directly from the committed `dist/index.js` file.

## How It Works

When a PR is created or updated, the action:

1. Checks if the branch is excluded from validation
2. Looks for existing DevConfig files
3. Analyzes git changes to detect core and service modifications
4. Generates a suggested DevConfig JSON
5. Posts a comment with copy-paste instructions

## Example Comment

```markdown
## DevConfig File Needed

This PR requires a DevConfig file. Here's the suggested DevConfig:

```json
{
  "core": {
    "changeLogMessages": ["Fix authentication bug"],
    "type": "patch",
    "updateMinimum": true
  }
}
```

**To add this DevConfig:**

1. Create the file `./generator/.DevConfigs/pr-123.json`
2. Copy the JSON above into the file
3. Commit and push the file to your PR
```

## Contributing

1. Make changes to the source files in `lib/`
2. Update tests if needed
3. Run `npm run build` to create the distribution bundle
4. Test the action in a PR to verify functionality
